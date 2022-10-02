using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Упражнение 1.1.Создание основы веб-сайта ASP.NET

// Создание модели данных

namespace AspNet
{
    // п.1-2
    public class GuestResponse
    {
        // п.3
        public int GuestResponseIdId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public DateTime Rdata { get; set; }

        // п.4
        public GuestResponse() { }
        public GuestResponse(string name, string email, string phone, bool? willattend)
        {
            Name = name;
            Email = email;
            Phone = phone;
            WillAttend = willattend;
            Rdata = DateTime.Now;
        }
    }
}