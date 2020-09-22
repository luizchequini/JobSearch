using JobSearch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.App.Services
{
    public class JobService : Service
    {
        public async Task<IEnumerable<Job>> GetJobs(string word, string citystate, int numberofpage = 1)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_baseApiUrl}/api/jobs?word={word}&citystate={citystate}&numberofpage={numberofpage}");

            List<Job> list = null;

            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<Job>>();
            }

            return list;

        }

        public async Task<Job> GetJob(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_baseApiUrl}/api/Jobs/{id}");

            Job job = null;

            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<Job>();
            }

            return job;
        }

        public async Task<Job> AddJob(Job job)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}/api/jobs/", job);

            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<Job>();
            }
            else
            {
                job = null;
            }

            return job;
        }
    }
}
