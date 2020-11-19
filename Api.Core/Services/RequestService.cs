using Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.Constants;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace Api.Core.Services
{
    class RequestService : IRequestService
    {
        public async Task MethodAsync()
        {
            await "https://api.spacexdata.com/"
                .AppendPathSegments("v4", "landpads")
                .GetJsonListAsync();
        }
    }
}
