using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class AccountProgram
    {
        public AccountProgram()
        {
            this.Accounts = new List<Account>();
            this.Programs = new List<Program>();
        }

        public int AccountProgramID { get; set; }
        public string ProgramPhase { get; set; }
        public string AccountID { get; set; }
        public System.DateTime ProgramGoLiveDate { get; set; }
        public System.DateTime ProgramStabilizationDate { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
    }
}
