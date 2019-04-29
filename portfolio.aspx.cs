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

namespace CRM
{
    public partial class portfolio : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            try
            {
                ds = objinteraction.PortfolioSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                       Repeater1.DataSource= ds.Tables[1];
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