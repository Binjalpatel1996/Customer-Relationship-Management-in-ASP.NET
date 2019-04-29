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
    public partial class career : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        InteractionMethod objinteraction = new InteractionMethod();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();

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