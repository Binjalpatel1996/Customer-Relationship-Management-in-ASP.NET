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
    public partial class About_Us : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        InteractionMethod objinteraction = new InteractionMethod();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
            BindAboutUs();
        }

        private void BindAboutUs()
        {
            try
            {
                ds = objinteraction.AboutusSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        Repeater2.DataSource = ds.Tables[1];
                        Repeater2.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void BindData()
        {
            try
            {
                ds = objinteraction.CareerSelectAll();
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
    }
}