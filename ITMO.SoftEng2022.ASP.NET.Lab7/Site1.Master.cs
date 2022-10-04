using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long numVisitors = 0; // л.р.7 п.6

            // л.р.7 п.7
            if (Application["Visitors"] != null)
            {
                numVisitors = long.Parse(Application["Visitors"].ToString());
            }

            VisitorLiteral.Text = "Число посещений: " + numVisitors.ToString(); // л.р.7 п.8
        }

    }
}
