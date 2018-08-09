using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHelloClient
{
    public partial class WebHello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebHelloService.WebHello sayhello = new WebHelloService.WebHello();
            this.TextBox1.Text = sayhello.Hello("linda");

        }
    }
}