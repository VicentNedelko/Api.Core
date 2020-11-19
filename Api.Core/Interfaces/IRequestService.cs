using Api.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Interfaces
{
    public interface IRequestService
    {
        Task<MainResponce> MethodAsync();
    }
}
