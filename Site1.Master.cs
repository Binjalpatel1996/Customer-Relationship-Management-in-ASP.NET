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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserLogInData"] == null)
            {
                Response.Redirect("Login-form.aspx");
            }
            if (!IsPostBack)
            {
                BindData();
                SetPagename();
            
            }
        }

        private void SetPagename()
        {
            try
            {
                String Pagename = System.IO.Path.GetFileName(Request.Url.AbsolutePath);

                if (Pagename == "About-us.aspx")
                {
                    lblpagename.Text = "About Us";
                }
                else if (Pagename == "Career-Post.aspx")
                {
                    lblpagename.Text = "Career Post";
                }
                else if (Pagename == "Contact-info.aspx")
                {
                    lblpagename.Text = "Contact Info";
                }
                else if (Pagename == "default.aspx")
                {
                    lblpagename.Text = "Dashboard";
                }
                else if (Pagename == "Enquiry.aspx")
                {

                    lblpagename.Text = "Enquiry";
                }
                else if (Pagename == "Event-Gallery.aspx")
                {
                    lblpagename.Text = "Event Gallery";
                }
                else if (Pagename == "Faq.aspx")
                {
                    lblpagename.Text = "Faq";
                }
                else if (Pagename == "Images.aspx")
                {
                    lblpagename.Text = "Event Images";
                }
                else if (Pagename == "Login-Form.aspx")
                {
                    lblpagename.Text = "Login";
                }
                else if (Pagename == "managep-ortfolio.aspx")
                {
                    lblpagename.Text = "Portfolio";
                }
                else if (Pagename == "manage-slider.aspx")
                {
                    lblpagename.Text = "Slider";
                }
                else if (Pagename == "NewsLetter.aspx")
                {
                    lblpagename.Text = "Newsletter";
                }
                else if (Pagename == "Socialmedia-Info.aspx")
                {
                    lblpagename.Text = "Social Meadia info";
                }
                else if (Pagename == "Testiomonial.aspx")
                {
                    lblpagename.Text = "Testimonial";
                }
                else if (Pagename == "User-Profile.aspx") 
                {
                    lblpagename.Text = "User Profile";
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void BindData()
        {
            try {
                try
                {
                    ds = objinteraction.loginSelectAll();
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            Repeater1.DataSource = ds.Tables[1];
                            Repeater1.DataBind();
                        }
                    }
                }
                catch (Exception)
                {

                }
            
            
            }
            catch { }
        }
    }
}