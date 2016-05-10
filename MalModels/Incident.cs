using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Incident
    {
        public int ID { get; set; }
        public string INCIDENTNUMBER { get; set; }
        public string SUBMITTER { get; set; }
        public System.DateTime REPORTEDDATE { get; set; }
        public System.DateTime LASTRESOLVEDDATE { get; set; }
        public string OWNERGROUP { get; set; }
        public string COMPANY { get; set; }
        public string CATEGORIZATIONTIER1 { get; set; }
        public string VATEGORIZATIONTIER2 { get; set; }
        public string CATEGORIZATIONTIER3 { get; set; }
        public string RESOLUTIONCATEGORY { get; set; }
        public string RESOLUTIONCATEGORYTIER2 { get; set; }
        public string RESOLUTIONCATEGORYTIER3 { get; set; }
        public string REPORTEDSOURCE { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
