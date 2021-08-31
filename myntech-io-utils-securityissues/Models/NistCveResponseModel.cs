using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace myntech_io_utils_securityissues.Models
{
    public class NistCveResponseModel
    {
        [JsonPropertyName("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }

    public class CVEDataMeta
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("ASSIGNER")]
        public string ASSIGNER { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("description_data")]
        public List<DescriptionData> DescriptionData { get; set; }
    }

    public class ProblemtypeData
    {
        [JsonPropertyName("description")]
        public List<Description> Description { get; set; }
    }

    public class Problemtype
    {
        [JsonPropertyName("problemtype_data")]
        public List<ProblemtypeData> ProblemtypeData { get; set; }
    }

    public class ReferenceData
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("refsource")]
        public string Refsource { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }

    public class References
    {
        [JsonPropertyName("reference_data")]
        public List<ReferenceData> ReferenceData { get; set; }
    }

    public class DescriptionData
    {
        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Cve
    {
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        [JsonPropertyName("data_format")]
        public string DataFormat { get; set; }

        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        [JsonPropertyName("CVE_data_meta")]
        public CVEDataMeta CVEDataMeta { get; set; }

        [JsonPropertyName("problemtype")]
        public Problemtype Problemtype { get; set; }

        [JsonPropertyName("references")]
        public References References { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }
    }

    public class CpeMatch
    {
        [JsonPropertyName("vulnerable")]
        public bool Vulnerable { get; set; }

        [JsonPropertyName("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonPropertyName("versionEndIncluding")]
        public string VersionEndIncluding { get; set; }

        [JsonPropertyName("cpe_name")]
        public List<object> CpeName { get; set; }

        [JsonPropertyName("versionStartIncluding")]
        public string VersionStartIncluding { get; set; }

        [JsonPropertyName("versionEndExcluding")]
        public string VersionEndExcluding { get; set; }
    }

    public class Child
    {
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        [JsonPropertyName("children")]
        public List<object> Children { get; set; }

        [JsonPropertyName("cpe_match")]
        public List<CpeMatch> CpeMatch { get; set; }
    }

    public class Node
    {
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }

        [JsonPropertyName("cpe_match")]
        public List<CpeMatch> CpeMatch { get; set; }
    }

    public class Configurations
    {
        [JsonPropertyName("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonPropertyName("nodes")]
        public List<Node> Nodes { get; set; }
    }

    public class CvssV3
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("vectorString")]
        public string VectorString { get; set; }

        [JsonPropertyName("attackVector")]
        public string AttackVector { get; set; }

        [JsonPropertyName("attackComplexity")]
        public string AttackComplexity { get; set; }

        [JsonPropertyName("privilegesRequired")]
        public string PrivilegesRequired { get; set; }

        [JsonPropertyName("userInteraction")]
        public string UserInteraction { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonPropertyName("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonPropertyName("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonPropertyName("baseScore")]
        public double BaseScore { get; set; }

        [JsonPropertyName("baseSeverity")]
        public string BaseSeverity { get; set; }
    }

    public class BaseMetricV3
    {
        [JsonPropertyName("cvssV3")]
        public CvssV3 CvssV3 { get; set; }

        [JsonPropertyName("exploitabilityScore")]
        public double ExploitabilityScore { get; set; }

        [JsonPropertyName("impactScore")]
        public double ImpactScore { get; set; }
    }

    public class CvssV2
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("vectorString")]
        public string VectorString { get; set; }

        [JsonPropertyName("accessVector")]
        public string AccessVector { get; set; }

        [JsonPropertyName("accessComplexity")]
        public string AccessComplexity { get; set; }

        [JsonPropertyName("authentication")]
        public string Authentication { get; set; }

        [JsonPropertyName("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonPropertyName("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonPropertyName("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonPropertyName("baseScore")]
        public double BaseScore { get; set; }
    }

    public class BaseMetricV2
    {
        [JsonPropertyName("cvssV2")]
        public CvssV2 CvssV2 { get; set; }

        [JsonPropertyName("severity")]
        public string Severity { get; set; }

        [JsonPropertyName("exploitabilityScore")]
        public double ExploitabilityScore { get; set; }

        [JsonPropertyName("impactScore")]
        public double ImpactScore { get; set; }

        [JsonPropertyName("acInsufInfo")]
        public bool AcInsufInfo { get; set; }

        [JsonPropertyName("obtainAllPrivilege")]
        public bool ObtainAllPrivilege { get; set; }

        [JsonPropertyName("obtainUserPrivilege")]
        public bool ObtainUserPrivilege { get; set; }

        [JsonPropertyName("obtainOtherPrivilege")]
        public bool ObtainOtherPrivilege { get; set; }

        [JsonPropertyName("userInteractionRequired")]
        public bool UserInteractionRequired { get; set; }
    }

    public class Impact
    {
        [JsonPropertyName("baseMetricV3")]
        public BaseMetricV3 BaseMetricV3 { get; set; }

        [JsonPropertyName("baseMetricV2")]
        public BaseMetricV2 BaseMetricV2 { get; set; }
    }

    public class CVEItem
    {
        [JsonPropertyName("cve")]
        public Cve Cve { get; set; }

        [JsonPropertyName("configurations")]
        public Configurations Configurations { get; set; }

        [JsonPropertyName("impact")]
        public Impact Impact { get; set; }

        [JsonPropertyName("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonPropertyName("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("CVE_data_type")]
        public string CVEDataType { get; set; }

        [JsonPropertyName("CVE_data_format")]
        public string CVEDataFormat { get; set; }

        [JsonPropertyName("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonPropertyName("CVE_data_timestamp")]
        public string CVEDataTimestamp { get; set; }

        [JsonPropertyName("CVE_Items")]
        public List<CVEItem> CVEItems { get; set; }
    }
}
