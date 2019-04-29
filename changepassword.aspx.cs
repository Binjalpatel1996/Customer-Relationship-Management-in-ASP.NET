using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
using BAL;

namespace CRM
{
    public partial class changepassword : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dsuser = new DataTable();
                dsuser = (DataTable)Session["UserLogInData"];
                objvalue.Password = txtCurrentpassword.Text;
                objvalue.Username = dsuser.Rows[0]["Username"].ToString();
                if (!string.IsNullOrEmpty(txtCurrentpassword.Text))
                {
                    if (txtNewpassword.Text == txtconfirmpassword.Text)
                    {
                        ds = objinteraction.CheckLogin(objvalue);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                objvalue.NewPassword = txtNewpassword.Text;
                                objinteraction.Updatepassword(objvalue);
                            }
                            else
                            {
                                lblmsg.Text = "Invalid Credential";
                            }
                        }
                    }
                    else
                    {
                        lblmsg.Text = "Password does not match";
                    }
                }
                else
                {
                    lblmsg.Text = "Please Enter your Current Password ";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}