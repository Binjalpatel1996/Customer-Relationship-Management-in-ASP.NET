using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BAL;
using System.Data;

namespace CRM
{
    public partial class Default : System.Web.UI.Page
    {
        DataSet ds= new DataSet();
        InteractionMethod objinteraction = new InteractionMethod();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSlider();
                BindData();
                BindPortfolio();
            }
        }

        private void BindPortfolio()
        {
            try
            {
                ds = objinteraction.PortfolioSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        Repeater2.DataSource = ds.Tables[2];
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
                ds = objinteraction.TestimonialSelectAll();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Repeater1.DataSource = ds.Tables[0];
                        Repeater1.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void BindSlider()
        {
            try
            {
                ds = objinteraction.SliderImagesSelectAll();
                if (ds.Tables.Count>0)
                {
                    if (ds.Tables[1].Rows.Count>0)
                    {
                        repSlider.DataSource = ds.Tables[1];
                        repSlider.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}