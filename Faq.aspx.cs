using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using BAL;
using DAL;

namespace CRM
{
    public partial class Faq : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }

        }

        private void BindRepeater()
        {
            ds = objinteraction.FaqSelectAll();
            Repeaterid1.DataSource = ds;
            Repeaterid1.DataBind();
        }

        protected void btnAddFaq_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAddFaq.Text == "Add FAQ")
                {
                    objvalue.Question = txtQuestion.Text;
                    objvalue.Answer = txtAnswer.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.FaqInsert(objvalue);
                    BindRepeater();
                    ClearFormData();
                }
                else
                {
                    objvalue.FaqID = Convert.ToInt32(hnId.Value);
                    objvalue.Question = txtQuestion.Text;
                    objvalue.Answer = txtAnswer.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.FaqUpdate(objvalue);
                    BindRepeater();
                    ClearFormData();

                    btnAddFaq.Text = "Add FAQ";


                }
            }
            catch (Exception)
            { }
        }

        private void ClearFormData()
        {
            txtAnswer.Text = "";
            txtAnswer.Text = "";
        }

        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.FaqID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.FaqDelete(objvalue);
                    BindRepeater();

                }
                if (e.CommandName == "Activate")
                {
                    objvalue.FaqID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.FaqDelete(objvalue);
                    BindRepeater();
                }
                if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.FaqID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.FaqSelectById(objvalue);
                    txtQuestion.Text = ds.Tables[0].Rows[0]["Question"].ToString();
                    txtAnswer.Text = ds.Tables[0].Rows[0]["Answer"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    btnAddFaq.Text = "Update";
                }
            }
            catch (Exception)
            { }
        }
    }
}