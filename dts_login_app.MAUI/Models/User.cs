using System;
using System.Collections.Generic;
using System.Text;

namespace dts_login_app.MAUI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
