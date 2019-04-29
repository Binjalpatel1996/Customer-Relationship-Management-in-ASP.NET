using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using BAL;


namespace CRM
{
    public partial class Career_Post : System.Web.UI.Page
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
                ds = objinteraction.CareerSelectAll();
                Repeater1.DataSource = ds;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnPost.Text == "Post")
                {
                    objvalue.Technology = Convert.ToString(DropDownList1.SelectedItem.Text);
                    objvalue.Post = txtPost.Text;
                    objvalue.NumOfVacancies = Convert.ToInt32(txtVacancies.Text);
                    objvalue.JobLocation = txtJoblocation.Text;
                    objvalue.Qualification = txtQualification.Text;
                    objvalue.RequiredSkills = txtReqiredskill.Text;
                    objvalue.ExtraContent = txtExtradetails.Text;
                    objvalue.Flag = objvalue.Flag;
                    objvalue.CreatedDate = DateTime.Now;
                    objinteraction.CareerInsert(objvalue);
                    BindData();
                    ClearFormData();
                }
                else
                {
                    objvalue.CareerVacanciesID = Convert.ToInt32(hnId.Value);
                    objvalue.Technology = DropDownList1.SelectedItem.Text;
                    objvalue.Post = txtPost.Text;
                    objvalue.NumOfVacancies = Convert.ToInt32(txtVacancies.Text);
                    objvalue.JobLocation = txtJoblocation.Text;
                    objvalue.Qualification = txtQualification.Text;
                    objvalue.RequiredSkills = txtReqiredskill.Text;
                    objvalue.ExtraContent = txtExtradetails.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.CareerUpdate(objvalue);
                    BindData();
                    ClearFormData();
                    BtnPost.Text = "Post";

                }
            }
            catch (Exception)
            { }

        }

        private void ClearFormData()
        {
            DropDownList1.SelectedItem.Text = "";
            txtPost.Text = "";
            txtVacancies.Text = "";
            txtJoblocation.Text = "";
            txtQualification.Text = "";
            txtReqiredskill.Text = "";
            txtExtradetails.Text = "";
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Dectivate")
                {
                    objvalue.CareerVacanciesID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.CareerDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.CareerVacanciesID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.CareerDelete(objvalue);
                    BindData();

                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.CareerVacanciesID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.CareerSelectById(objvalue);
                    DropDownList1.SelectedItem.Text = ds.Tables[0].Rows[0]["Technology"].ToString();
                    txtPost.Text = ds.Tables[0].Rows[0]["Post"].ToString();
                    txtVacancies.Text = ds.Tables[0].Rows[0]["NumOfVacancies"].ToString();
                    txtJoblocation.Text = ds.Tables[0].Rows[0]["JobLocation"].ToString();
                    txtQualification.Text = ds.Tables[0].Rows[0]["Qualification"].ToString();
                    txtReqiredskill.Text = ds.Tables[0].Rows[0]["RequiredSkills"].ToString();
                    txtExtradetails.Text = ds.Tables[0].Rows[0]["ExtraContent"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    BtnPost.Text = "Update";
                }
            }
            catch (Exception)
            { }
        }
        
    }
}