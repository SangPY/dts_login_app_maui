using dts_login_app.MAUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dts_login_app.MAUI.Services
{
    public interface ILoginService
    {
        Task<User> Login(string email, string password);
    }
}
