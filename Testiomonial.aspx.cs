using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BAL;
using DAL;
using System.IO;

namespace CRM
{
    public partial class Testiomonial : System.Web.UI.Page
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
                ds = objinteraction.TestimonialSelectAll();
                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch(Exception)
            { }
        }

        //protected void btnAddTestimonial_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (btnAddTestimonial.Text == "ADD")
        //        {
        //            objvalue.Name = txtName.Text;
        //            objvalue.Testimonial = txtTestimonial.Text;
        //            objvalue.CreatedDate = DateTime.Now;
        //            objvalue.Flag = objvalue.Flag;
        //            objinteraction.TestimonialInsert(objvalue);
        //            BindData();
        //        }
        //        else
        //        {
        //            objvalue.TestimonialID = Convert.ToInt32(hnId.Value);
        //            objvalue.Name = txtName.Text;
        //            objvalue.Testimonial = txtTestimonial.Text;
        //            objvalue.UpdatedDate = DateTime.Now;
        //            objinteraction.TestimonialUpdate(objvalue);
        //            BindData();
        //            btnAddTestimonial.Text = "ADD";


        //        }
        //    }
        //    catch (Exception)
        //    { }
        //}
       

        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.TestimonialID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.TestimonialDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.TestimonialID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.TestimonialDelete(objvalue);
                    BindData();

                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();
                    objvalue.TestimonialID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.TestimonialSelectById(objvalue);
                    txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    txtTestimonial.Text = ds.Tables[0].Rows[0]["Testimonial"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    btnAddTestimonial.Text = "Update";

                }
            }
            catch (Exception)
            { }
        }

        protected void btnAddTestimonial_Click1(object sender, EventArgs e)
        {
            try
            {
                if (btnAddTestimonial.Text == "Add")
                {
                    objvalue.Name = txtName.Text;
                    objvalue.Testimonial = txtTestimonial.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.TestimonialInsert(objvalue);
                    BindData();
                }
                else
                {
                    objvalue.TestimonialID = Convert.ToInt32(hnId.Value);
                    objvalue.Name = txtName.Text;
                    objvalue.Testimonial = txtTestimonial.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.TestimonialUpdate(objvalue);
                    BindData();
                    btnAddTestimonial.Text = "Add";


                }
            }
            catch (Exception)
            { }
        }
    }

}