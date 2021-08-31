using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using myntech_io_utils_securityissues.Helpers;
using myntech_io_utils_securityissues.Models;

namespace myntech_io_utils_securityissues.Controllers
{
    [ApiController]
    public class SecurityIssueController : ControllerBase
    {
        private IConfiguration configuration;

        public SecurityIssueController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        [Authorize]
        [HttpPost]
        [Route("securityissues/cve")]
        public async Task<ApiResponseModel> Get(NistCveRequestModel inputModel)
        {
            ApiResponseModel itemToReturn = new ApiResponseModel();

            try
            {
                var url = $"{configuration.GetSection("BaseUrls")["NistBaseApiUrl"]}/cves/1.0?startIndex={inputModel.StartIndex}";

                #region BUILDING THE QUERY
                if (inputModel.ResultsPerPage > 0)
                {
                    url = $"{url}&resultsPerPage={inputModel.ResultsPerPage}";
                }

                if (!String.IsNullOrEmpty(inputModel.PubStartDate))
                {
                    url = $"{url}&pubStartDate={inputModel.PubStartDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.PubEndDate))
                {
                    url = $"{url}&pubEndDate={inputModel.PubEndDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.ModStartDate))
                {
                    url = $"{url}&modStartDate={inputModel.ModStartDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.ModEndDate))
                {
                    url = $"{url}&modEndDate={inputModel.ModEndDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.Keyword))
                {
                    url = $"{url}&keyword={inputModel.Keyword.Replace(" ", "+")}";
                }

                if (!String.IsNullOrEmpty(inputModel.CWEId))
                {
                    url = $"{url}&cweId={inputModel.CWEId}";
                }

                if (!String.IsNullOrEmpty(inputModel.CvssV2Severity))
                {
                    url = $"{url}&cvssV2Severity={inputModel.CvssV2Severity}";
                }

                if (!String.IsNullOrEmpty(inputModel.CvssV3Severity))
                {
                    url = $"{url}&cvssV3Severity={inputModel.CvssV3Severity}";
                }

                if (!String.IsNullOrEmpty(inputModel.CvssV2Metrics))
                {
                    url = $"{url}&cvssV2Metrics={inputModel.CvssV2Metrics}";
                }

                if (!String.IsNullOrEmpty(inputModel.CvssV3Metrics))
                {
                    url = $"{url}&cvssV3Metrics={inputModel.CvssV3Metrics}";
                }

                if (!String.IsNullOrEmpty(inputModel.CpeMatchString))
                {
                    url = $"{url}&cpeMatchString={inputModel.CpeMatchString}";
                }

                if (!String.IsNullOrEmpty(inputModel.CpeName))
                {
                    url = $"{url}&cpeName={inputModel.CpeName}";
                }

                if (!String.IsNullOrEmpty(inputModel.AddOns))
                {
                    url = $"{url}&addOns={inputModel.AddOns}";
                }

                url = $"{url}&includeMatchStringChange={inputModel.IncludeMatchStringChange}";
                url = $"{url}&isExactMatch={inputModel.IsExactMatch}";
                #endregion

                var result = await new ApiCaller().PerformGetRequest(url);
                var data = await JsonSerializer.DeserializeAsync<NistCveResponseModel>(result);

                itemToReturn.Payload = data;
                itemToReturn.Status = "OK";
            }
            catch(Exception ex)
            {
                itemToReturn.Payload = false;
                itemToReturn.Status = "KO";
                itemToReturn.ErrorMessage = ex.Message;
            }

            return await Task.FromResult(itemToReturn);
        }

        [Authorize]
        [HttpPost]
        [Route("securityissues/cpe")]
        public async Task<ApiResponseModel> Get(NistCpeRequestModel inputModel)
        {
            ApiResponseModel itemToReturn = new ApiResponseModel();

            try
            {
                var url = $"{configuration.GetSection("BaseUrls")["NistBaseApiUrl"]}/cpes/1.0?startIndex={inputModel.StartIndex}";

                #region BUILDING THE QUERY
                if (inputModel.ResultsPerPage > 0)
                {
                    url = $"{url}&resultsPerPage={inputModel.ResultsPerPage}";
                }
                if (!String.IsNullOrEmpty(inputModel.ModStartDate))
                {
                    url = $"{url}&modStartDate={inputModel.ModStartDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.ModEndDate))
                {
                    url = $"{url}&modEndDate={inputModel.ModEndDate}";
                }

                if (!String.IsNullOrEmpty(inputModel.Keyword))
                {
                    url = $"{url}&keyword={inputModel.Keyword.Replace(" ", "+")}";
                }

                if (!String.IsNullOrEmpty(inputModel.CpeMatchString))
                {
                    url = $"{url}&cpeMatchString={inputModel.CpeMatchString}";
                }

                if (!String.IsNullOrEmpty(inputModel.AddOns))
                {
                    url = $"{url}&addOns={inputModel.AddOns}";
                }

                url = $"{url}&includeDeprecated={inputModel.IncludeDeprecated}";
                #endregion

                var result = await new ApiCaller().PerformGetRequest(url);
                var data = await JsonSerializer.DeserializeAsync<NistCpeResponseModel>(result);

                itemToReturn.Payload = data;
                itemToReturn.Status = "OK";
            }
            catch (Exception ex)
            {
                itemToReturn.Payload = false;
                itemToReturn.Status = "KO";
                itemToReturn.ErrorMessage = ex.Message;
            }

            return await Task.FromResult(itemToReturn);
        }
    }
}
