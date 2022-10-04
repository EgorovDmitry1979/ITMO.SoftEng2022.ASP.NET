using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;


// Лабораторная работа 7. Управление состоянием в веб-приложениях 
// Упражнение 1.Отображение значения счетчика посещений 

namespace AspNet
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Visitors"] = 0; // п.2 Инициализация переменной приложения 
        }

        // л.р.7 Обновление счетчика посещений в новой сессии 
        void Session_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске нового сеанса 
            // Increment Visitors counter 
            Application["Visitors"] = long.Parse(Application["Visitors"].ToString()) + 1;
        }
    }
}