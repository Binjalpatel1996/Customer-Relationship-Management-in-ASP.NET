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
    public partial class ClientMasterPage : System.Web.UI.MasterPage
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = objinteraction.ContactUsSelectAll();
            lblStreetname.Enabled = true;
            lblCity.Enabled = true;
            lblZipcode.Enabled = true;
            lblState.Enabled = true;
            lblCountry.Enabled = true;
            lblContact1.Enabled = true;
            lblEmail.Enabled = true;
            lblStreetname.Text = ds.Tables[0].Rows[0]["Streetname"].ToString();
            lblCity.Text = ds.Tables[0].Rows[0]["City"].ToString();
            lblZipcode.Text = ds.Tables[0].Rows[0]["Zipcode"].ToString();
            lblState.Text = ds.Tables[0].Rows[0]["State"].ToString();
            lblCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
            lblContact1.Text = ds.Tables[0].Rows[0]["Contact1"].ToString();
            acontact1.HRef = "callto:" + ds.Tables[0].Rows[0]["Contact1"].ToString(); ;
            lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            aemail.HRef = "mailto:" + ds.Tables[0].Rows[0]["Email"].ToString();
            BindData();
            bindrepeater();
            repeaterabout();
        }

        private void repeaterabout()
        {
            try
            {
                ds = objinteraction.AboutusSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        repeateraboutus.DataSource = ds.Tables[1];
                        repeateraboutus.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        

        private void bindrepeater()
        {

            try 
            {
                ds = objinteraction.socialmediaSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        atwitter.HRef = ds.Tables[0].Rows[0]["TwitterURL"].ToString();
                        alinkedin.HRef = ds.Tables[0].Rows[0]["LinkedinURL"].ToString();
                        afacebook.HRef = ds.Tables[0].Rows[0]["FacebookURL"].ToString();
                    
                    }
                
                }
            
            }

            catch { }
        }

        private void BindData()
        {
            try
            {
                ds = objinteraction.PortfolioSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        Repeater1.DataSource = ds.Tables[3];
                        Repeater1.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    objvalue.Email = txtEmail.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.NewsLetterInsert(objvalue);
                    clearFieldData();
                }
                else {

                    lblmsg.Text = "Please Enter Your Email ID!!";
                
                }
            }
            catch(Exception)
            { }
            
        }

        private void clearFieldData()
        {
            txtEmail.Text = "";
        }
    }
}