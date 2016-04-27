using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class Account
    {
        public Account()
        {
            this.AccountAlias = new List<AccountAlia>();
            this.ChangeMeasures = new List<ChangeMeasure>();
            this.AccountTools = new List<AccountTool>();
        }
        [Key]
        public int ID { get; set; }
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string ParentAccountId { get; set; }
        public string ParentAccountName { get; set; }
        public string MasterAccountId { get; set; }
        public string MasterAccountName { get; set; }
        public string Customer { get; set; }
        public string SnowDomainName { get; set; }
        public string CapCode { get; set; }
        public Nullable<double> AccountTcvPotential { get; set; }
        public Nullable<double> AccountTcvAwarded { get; set; }
        public Nullable<System.DateTime> ContractStartDate { get; set; }
        public Nullable<System.DateTime> ContractExpiryDate { get; set; }
        public string ContractType { get; set; }
        public Nullable<double> ContractTermInMonth { get; set; }
        public Nullable<int> CurrentContractYear { get; set; }
        public string ContractBaseOptions { get; set; }
        public string SfdcIdNumber { get; set; }
        public Nullable<bool> HasServiceLevelAgreements { get; set; }
        public Nullable<bool> HasContractualReportingRequirements { get; set; }
        public string AccountFinancialsParentFamily { get; set; }
        public string PaymentTerms { get; set; }
        public string SecurityRestrictions { get; set; }
        public string WorkScope { get; set; }
        public string AccountStatus { get; set; }
        public string Comments { get; set; }
        public string AccountIndustry { get; set; }
        public string AccountCountry { get; set; }
        public string AccountRegion { get; set; }
        public string PrimaryDeliveryRegion { get; set; }
        public string OedRegion { get; set; }
        public string LeadOffering { get; set; }
        public Nullable<int> AccountRolePerson_AccountRolePersonID { get; set; }
        public Nullable<int> Service_ServiceID { get; set; }
        public Nullable<int> AccountProgram_AccountProgramID { get; set; }
        public virtual ICollection<AccountAlia> AccountAlias { get; set; }
        public virtual AccountProgram AccountProgram { get; set; }
        public virtual AccountRolePerson AccountRolePerson { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<ChangeMeasure> ChangeMeasures { get; set; }
        public virtual ICollection<AccountTool> AccountTools { get; set; }
    }
}
