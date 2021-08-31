using System;
namespace myntech_io_utils_securityissues.Models
{
    public class NistCpeRequestModel
    {
        public Int64 StartIndex { get; set; }

        public Int64 ResultsPerPage { get; set; }

        public string ModStartDate { get; set; }

        public string ModEndDate { get; set; }

        public string Keyword { get; set; }

        public bool IncludeDeprecated { get; set; }

        public string CpeMatchString { get; set; }

        public string AddOns { get; set; }
    }
}
