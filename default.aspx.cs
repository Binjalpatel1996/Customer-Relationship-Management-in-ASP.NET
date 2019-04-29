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
    public partial class _default : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ds = objinteraction.CountSelectedDashboard();
                TotalEnquiry.Enabled = true;
                Label2.Enabled = true;
                TotalEnquiry.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[1].Rows[0][0].ToString();
                lblTotaltestimonial.Text = ds.Tables[2].Rows[0][0].ToString();
                lblTotalportfolio.Text = ds.Tables[3].Rows[0][0].ToString();
            }
            catch (Exception)
            { }
        }
    }
}