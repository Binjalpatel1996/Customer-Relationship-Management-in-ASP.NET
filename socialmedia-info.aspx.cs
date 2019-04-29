using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DAL;
using System.Data;
using System.IO;

namespace CRM.Admin
{
    public partial class socialmedia_info : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                filldata();
            }

        }

        private void filldata()
        {
            try
            {
                ds = objinteraction.socialmediaSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtFacebookurl.Text = ds.Tables[0].Rows[0]["FacebookURL"].ToString();
                        txtTwitterurl.Text = ds.Tables[0].Rows[0]["TwitterURL"].ToString();
                        txtLinkedinurl.Text = ds.Tables[0].Rows[0]["LinkedinURL"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
           
        }

        protected void btnsocialinfo_Click(object sender, EventArgs e)
        {
            try
            {
                objvalue.FacebookURL = txtFacebookurl.Text;
                objvalue.TwitterURL = txtTwitterurl.Text;
                objvalue.LinkedinURL = txtLinkedinurl.Text;
                objvalue.CreatedDate = DateTime.Now;
                objvalue.Flag = objvalue.Flag;
                objinteraction.socialmediaInsert(objvalue);
                filldata();

            }
            catch (Exception)
            { }
        }

       
    }
}