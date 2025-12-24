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
            try
            {
                var client = new HttpClient();
                string localhostUrl = "https://localhost:7069/api/User/" + email + "/" + password;
                client.BaseAddress = new Uri(localhostUrl);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    User user = await response.Content.ReadFromJsonAsync<User>();
                    return await Task.FromResult(user!);
                }
                return null;
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
                return null;
            }
        }
    }
}
