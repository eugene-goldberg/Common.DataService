using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class DimSubjectType
    {
        [Key]
        public int SubjectTypeKey { get; set; }
        public string SubjectType1 { get; set; }
        public string SubjectType2 { get; set; }
        public string SubjectType3 { get; set; }
        public string SubjectType4 { get; set; }
        public string SubjectType5 { get; set; }
        public string SubjectType6 { get; set; }
        public string SubjectType7 { get; set; }
    }
}
