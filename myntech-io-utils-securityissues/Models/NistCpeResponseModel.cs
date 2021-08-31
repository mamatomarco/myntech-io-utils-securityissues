using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace myntech_io_utils_securityissues.Models
{
    public class NistCpeResponseModel
    {
        [JsonPropertyName("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("result")]
        public CpeResult Result { get; set; }
    }

    public class Title
    {
        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }
    }

    public class Cpe
    {
        [JsonPropertyName("deprecated")]
        public bool Deprecated { get; set; }

        [JsonPropertyName("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonPropertyName("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonPropertyName("titles")]
        public List<Title> Titles { get; set; }

        [JsonPropertyName("refs")]
        public List<object> Refs { get; set; }

        [JsonPropertyName("deprecatedBy")]
        public List<object> DeprecatedBy { get; set; }

        [JsonPropertyName("vulnerabilities")]
        public List<object> Vulnerabilities { get; set; }
    }

    public class CpeResult
    {
        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        [JsonPropertyName("feedVersion")]
        public string FeedVersion { get; set; }

        [JsonPropertyName("cpeCount")]
        public int CpeCount { get; set; }

        [JsonPropertyName("feedTimestamp")]
        public string FeedTimestamp { get; set; }

        [JsonPropertyName("cpes")]
        public List<Cpe> Cpes { get; set; }
    }
}
