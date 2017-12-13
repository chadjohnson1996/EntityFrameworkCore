using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaMeasurementGroups
    {
        public AcaMeasurementGroups()
        {
            AcaOngoingPeriods = new HashSet<AcaOngoingPeriods>();
            EmpAcaLookbackPeriods = new HashSet<EmpAcaLookbackPeriods>();
            Employees = new HashSet<Employees>();
        }

        public int CompanyNo { get; set; }
        public string MeasurementGroupNo { get; set; }
        public string Description { get; set; }
        public byte? OngoingStabilityStartMonth { get; set; }
        public int? OngoingStabilityStartYear { get; set; }
        public byte? OngoingAdminLength { get; set; }
        public byte? OngoingMeasurementLength { get; set; }
        public DateTime? OngoingMeasurementStartDate { get; set; }
        public byte? OngoingFullStabilityLength { get; set; }
        public byte? OngoingPartStabilityLength { get; set; }
        public string InitialMeasurementStart { get; set; }
        public byte? InitialMeasurementLength { get; set; }
        public byte? InitialAdminLength { get; set; }
        public byte? InitialFullStabilityLength { get; set; }
        public byte? InitialPartStabilityLength { get; set; }
        public string DefaultFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MeasurementGroupId { get; set; }

        public ICollection<AcaOngoingPeriods> AcaOngoingPeriods { get; set; }
        public ICollection<EmpAcaLookbackPeriods> EmpAcaLookbackPeriods { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
