using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppWithNunitTest
{
    public partial class CheckAdditionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectClass CCobj = new ConnectClass();
            CCobj.assign( Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text));
            Label3.Text = (Convert.ToInt32(TextBox1.Text)+Convert.ToInt32(TextBox2.Text)).ToString();
            Label3.Visible = true;
        }
    }
}