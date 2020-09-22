using JobSearch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.App.Services
{
    public class UserService : Service
    {
        public async Task<User> GetUser(string email, string password)
        {
            HttpResponseMessage response =  await _httpClient.GetAsync($"{_baseApiUrl}/api/Users?email={email}&password={password}");

            User user = null;

            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }

            return user;
        }

        public async Task<User> AddUser(User user)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}/api/users", user);

            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            else
            {
                user = null;
            }

            return user;
        }
    }
}
