using System;
namespace myntech_io_utils_securityissues.Models
{
    public class NistCveRequestModel
    {
        public Int64 StartIndex { get; set; }

        public Int64 ResultsPerPage { get; set; }

        public string PubStartDate { get; set; }

        public string PubEndDate { get; set; }

        public string ModStartDate { get; set; }

        public string ModEndDate { get; set; }

        public string Keyword { get; set; }

        public bool IncludeMatchStringChange { get; set; }

        public bool IsExactMatch { get; set; }

        public string CWEId { get; set; }

        public string CvssV2Severity { get; set; }

        public string CvssV3Severity { get; set; }

        public string CvssV2Metrics { get; set; }

        public string CvssV3Metrics { get; set; }

        public string CpeMatchString { get; set; }

        public string CpeName { get; set; }

        public string AddOns { get; set; }
    }
}
