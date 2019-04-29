using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BAL;
using DAL;

namespace CRM.Admin
{
    public partial class Enquiry : System.Web.UI.Page
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
                ds = objinteraction.EnquirySelectAll();
                Repeater1.DataSource = ds;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.EnquiryID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.EnquiryDelete(objvalue);
                    BindData();
                }
                else
                {
                    objvalue.EnquiryID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.EnquiryDelete(objvalue);
                    BindData();

                }
            }
            catch (Exception)
            { }
        }
    }
}