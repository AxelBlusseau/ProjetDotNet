using APIdotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdotNet.Services
{
    public interface IExcuseService
    {
        List<Excuse> GetExcuses();
        Excuse AddExcuse(Excuse excuse);
    }
}
