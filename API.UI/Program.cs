using System;
using Api.Core;
using Api.Core.Interfaces;
using Api.Core.Services;

namespace API.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestService request = new RequestService();
            var resp = request.MethodAsync().GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
