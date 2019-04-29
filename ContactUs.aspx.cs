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
    public partial class ContactUs : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = objinteraction.ContactUsSelectAll();
            lblStreetname.Enabled= true;
            lblCity.Enabled = true;
            lblZipcode.Enabled = true;
            lblState.Enabled = true;
            lblCountry.Enabled = true;
            lblContact1.Enabled = true;
            lblContact2.Enabled = true;
            lblEmail.Enabled = true;
            lblTiming.Enabled = true;
            lblStreetname.Text = ds.Tables[0].Rows[0]["Streetname"].ToString();
            lblCity.Text = ds.Tables[0].Rows[0]["City"].ToString();
            lblZipcode.Text = ds.Tables[0].Rows[0]["Zipcode"].ToString();
            lblState.Text = ds.Tables[0].Rows[0]["State"].ToString();
            lblCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
            acontact1.HRef = "callto:" + ds.Tables[0].Rows[0]["Contact1"].ToString();
            lblContact1.Text = ds.Tables[0].Rows[0]["Contact1"].ToString();
            acontact2.HRef = "callto:" + ds.Tables[0].Rows[0]["Contact2"].ToString();
            lblContact2.Text = ds.Tables[0].Rows[0]["Contact2"].ToString();
            lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            amailid.HRef = "mailto:" + ds.Tables[0].Rows[0]["Email"].ToString();
            lblTiming.Text = ds.Tables[0].Rows[0]["Timing"].ToString();
            abcd.Src=ds.Tables[0].Rows[0]["Map"].ToString();
            


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                objvalue.Name = txtName.Text;
                objvalue.Email = txtEmail.Text;
                objvalue.Phone = TextBox1.Text;
                objvalue.Subject = TextBox2.Text;
                objvalue.Message = txtmessage.Text;
                objvalue.CreatedDate = DateTime.Now;
                objvalue.Flag = objvalue.Flag;
                objinteraction.EnquiryInsert(objvalue);
                ClearFormData();
            }
            catch(Exception)
            {
               
            }
            
        }

        private void ClearFormData()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtmessage.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}