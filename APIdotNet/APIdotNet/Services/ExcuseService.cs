using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIdotNet.Models;

namespace APIdotNet.Services
{
    public class ExcuseService : IExcuseService
    {
        private readonly List<Excuse> _excuses;

        public ExcuseService()
        {
            _excuses = new List<Excuse>();
        }

        public Excuse AddExcuse(Excuse excuse)
        {
            _excuses.Add(excuse);
            return excuse;
        }

        public List<Excuse> GetExcuses()
        {
            return _excuses;
        }
    }
}
