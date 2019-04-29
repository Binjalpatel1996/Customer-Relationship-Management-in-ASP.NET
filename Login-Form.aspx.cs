using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DAL;
using System.Data;

namespace CRM
{
    public partial class Login_Form : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Session.Clear();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                objvalue.Username = txtUsername.Text;
                objvalue.Password = txtPassword.Text;
                ds = objinteraction.CheckLogin(objvalue);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Session["UserLogInData"] = ds.Tables[0];
                        lblmsg.Text = "Login Success";
                        Response.Redirect("default.aspx");
                    }
                    else
                    {
                        lblmsg.Text = "Login fail";
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void clearFormData()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}