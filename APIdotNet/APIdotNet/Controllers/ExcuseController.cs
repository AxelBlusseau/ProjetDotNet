using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIdotNet.Models;
using APIdotNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIdotNet.Controllers
{
    [Route("/")]
    [ApiController]
    public class ExcuseController : ControllerBase
    {
        private readonly IExcuseService _excuses;
        public ExcuseController(IExcuseService services)
        {
            _excuses = services;
        }

        [HttpGet]
        [Route("excuses")]
        public ActionResult<List<Excuse>> GetExcuses()
        {
            var excuses = _excuses.GetExcuses();
            if (excuses.Count == 0)
            {
                return NotFound();
            }

            return excuses;
        }
        [HttpPost]
        [Route("excuse")]
        public ActionResult<Excuse> AddExcuse(Excuse excuse)
        {
            _excuses.AddExcuse(excuse);
            return excuse;
        }
    }
}