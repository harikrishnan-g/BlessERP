using System;
using System.Collections.Generic;

namespace BlessERP.API.Models
{
    public partial class NurseHandoverBook
    {
        public int Id { get; set; }
        public int NurseHandoverBookCode { get; set; }
        public string NurseEmployeecode { get; set; }
        public DateTime? HandoverDate { get; set; }
        public decimal? CashinHand { get; set; }
        public string Notes { get; set; }
        public string CarpediumNotes { get; set; }
        public string SpecialdayNotes { get; set; }
        public string StaffNotes { get; set; }
        public string TechnicalNotes { get; set; }
        public string MaintenenceNotes { get; set; }
        public string HousekeepingNotes { get; set; }
        public string KeyHandOverNotes { get; set; }
        public string ShortstayNotes { get; set; }
        public string OtherInformation { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public string FranchiseCode { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? ModifiedUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
