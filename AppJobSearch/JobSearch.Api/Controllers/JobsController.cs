using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Api.Database;
using JobSearch.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private JobSearchContext _jobSearchContext;
        private int numberOfRegistryByPage = 5;

        public JobsController(JobSearchContext jobSearchContext)
        {
            _jobSearchContext = jobSearchContext;
        }

        [HttpGet]
        public IEnumerable<Job> GetJobs(string word, string cityState, int numberOfPage = 1)
        {
            if (word == null)
                word = "";

            if (cityState == null)
                cityState = "";

            return _jobSearchContext.Jobs
                .Where(a =>
                    a.PublicationDate >= DateTime.Now.AddDays(-15) &&
                    a.CityState.Contains(cityState.ToLower()) &&
                    (
                        a.JobTitle.ToLower().Contains(word.ToLower()) ||
                        a.TecnologyTools.ToLower().Contains(word.ToLower()) ||
                        a.Company.ToLower().Contains(word.ToLower())
                    )
                )
                .Skip(numberOfRegistryByPage * (numberOfPage - 1)) 
                .Take(numberOfRegistryByPage)
                .ToList<Job>();

            /*
             * Explicação do Skip
             * Skip serve para pular registros, então veja o exemplo abaixo
             * Se temos -> 5 * (1 - 1) = 0 - não irá pular registros, porque o cálculo resultou em 0
             * Se temos -> 5 * (2 - 1) = 5 - irá pular 5 registros, porque o cálculo resultou em 5
             * Se temos -> 5 * (3 - 1) = 10 - irá pular 10 registros, porque o cálculo resultou em 10
             * e assim por diante
             */
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            var JobDb = _jobSearchContext.Jobs.Find(id);

            if (JobDb == null)
            {
                return NotFound();
            }

            return new JsonResult(JobDb);
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            //TODO - Add Validação

            job.PublicationDate = DateTime.Now;

            _jobSearchContext.Add(job);
            _jobSearchContext.SaveChanges();

            return CreatedAtAction(nameof(GetJob), new { id = job.Id }, job);
        }
    }
}
