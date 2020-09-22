using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace JobSearch.App.Services
{
    public abstract class Service
    {
        protected HttpClient _httpClient;
        protected string _baseApiUrl = "https://xamarinforms2020api.azurewebsites.net";

        public Service()
        {
            _httpClient = new HttpClient();
        }
    }
}
