using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Program
    {
        public int ProgramID { get; set; }
        public string ProgramName { get; set; }
        public Nullable<int> AccountProgram_AccountProgramID { get; set; }
        public virtual AccountProgram AccountProgram { get; set; }
    }
}
