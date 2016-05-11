using System;
using System.ServiceProcess;
using System.Collections.Generic;
using Microsoft.Owin.Hosting;
using Topshelf;
using System.Threading.Tasks;
using System.Diagnostics;
using KafkaNet;
using KafkaNet.Model;
using KafkaNet.Protocol;
using System.Linq;
using Newtonsoft.Json;
using CommonDataService.Models;

namespace SelfHostedWebApiDataService
{
    
    class Program
    {
        static MALContext db = new MALContext();

        //public class Incident
        //{
        //    public  string INCIDENTNUMBER { get; set; }
        //    public  string SUBMITTER { get; set; }
        //    public  DateTime REPORTEDDATE { get; set; }
        //    public  DateTime LASTRESOLVEDDATE { get; set; }
        //    public  string OWNERGROUP { get; set; }
        //    public  string COMPANY { get; set; }
        //    public  string CATEGORIZATIONTIER1 { get; set; }
        //    public  string VATEGORIZATIONTIER2 { get; set; }
        //    public  string CATEGORIZATIONTIER3 { get; set; }
        //    public  string RESOLUTIONCATEGORY { get; set; }
        //    public  string RESOLUTIONCATEGORYTIER2 { get; set; }
        //    public  string RESOLUTIONCATEGORYTIER3 { get; set; }
        //    public  string REPORTEDSOURCE { get; set; }
        //    public  string DESCRIPTION { get; set; }
        //}
        public static async Task KafkaConsumerAsync()
            {
             string s1 = await ReadKafkaMessagesAsync();
             Console.WriteLine("KafkaConsumerAsync()");
            }

        private static Task<string> ReadKafkaMessagesAsync()
        {
            return Task<string>.Factory.StartNew(() => ReadKafkaMessages());
        }

        private static string ReadKafkaMessages()
        {
            var options = new KafkaOptions(new Uri("http://13.89.38.33:9092"), new Uri("http://13.89.38.33:9092"));
            var router = new BrokerRouter(options);

            var consumerOffset = new Consumer(new ConsumerOptions("ora1", router));

            var offsets = consumerOffset.GetTopicOffsetAsync("ora1").Result
                   .Select(x => new OffsetPosition(x.PartitionId, x.Offsets.Max())).ToArray();

            var consumer = new Consumer(new ConsumerOptions("ora1", router), offsets);

            //Consume returns a blocking IEnumerable (ie: never ending stream)
            foreach (var message in consumer.Consume())
            {
                string stringValue = System.Text.Encoding.Default.GetString(message.Value);

                var models = JsonConvert.DeserializeObject<IList<Incident>>(stringValue);

                foreach (Incident incident in models)
                {
                    Debug.WriteLine("MODEL:");
                    Debug.WriteLine(incident.INCIDENTNUMBER);
                    Debug.WriteLine(incident.SUBMITTER);
                    Debug.WriteLine(incident.REPORTEDDATE);
                    Debug.WriteLine(incident.OWNERGROUP);
                    Debug.WriteLine("MODEL END:");
                    Debug.WriteLine("\n\n");

                    db.Entry(incident).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }

            return null;
        }
        static void Main(string[] args)
        {
            //StartConsole();

            StartTopshelf();
        }

        static void StartTopshelf()
        {
            HostFactory.Run(x =>
            {
                x.Service<SelfHostedWebApiDataService.TopshelfService>(s =>
                {
                    s.ConstructUsing(name => new SelfHostedWebApiDataService.TopshelfService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Common Data Service");
                x.SetDisplayName("Common Data Service");
                x.SetServiceName("GommonDataService");
            });
        }

        static async void StartConsole()
        {
            await KafkaConsumerAsync();

            using (WebApp.Start<SelfHostedWebApiDataService.Startup>("http://*:8888"))
            {                
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }

        static void StartServiceBase()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SelfHostedWebApiDataService.SelfHostServiceBase()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
