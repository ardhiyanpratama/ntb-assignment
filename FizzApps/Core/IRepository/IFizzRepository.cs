using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzApps.Core.IRepository
{
    internal interface IFizzRepository
    {
        Task<string> Fizz(int sequence);
    }
}
