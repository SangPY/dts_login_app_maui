using dts_login_app.MAUI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace dts_login_app.MAUI.Services
{
    public class LoginService : ILoginService
    {
        public async Task<User> Login(string email, string password)
        {
            _ = new User();
            var client = new HttpClient();
            string url = "https://localhost:5000/api/User/" + email + "/" + password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                User user = await response.Content.ReadFromJsonAsync<User>();
                return await Task.FromResult(user!);
            }
            return null!;
        }
    }
}
