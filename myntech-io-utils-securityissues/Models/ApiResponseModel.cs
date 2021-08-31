using System;
namespace myntech_io_utils_securityissues.Models
{
    public class ApiResponseModel
    {
        public object Payload { get; set; }

        public string Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}
