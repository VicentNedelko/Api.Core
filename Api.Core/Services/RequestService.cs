using Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.Constants;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;
using Api.Core.Models;

namespace Api.Core.Services
{
    public class RequestService : IRequestService
    {
        public async Task<MainResponce> MethodAsync()
        {
            return await "https://api.spacexdata.com/"
                .AppendPathSegments("v4", "landpads")
                .GetJsonAsync<MainResponce>();
        }
    }
}
