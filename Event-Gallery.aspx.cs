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
using System.IO;

namespace CRM
{
    public partial class Event_Gallery : System.Web.UI.Page
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
                ds = objinteraction.EventgallerySelectAll();
                Repeater1.DataSource = ds;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAddEvent.Text == "Add Event")
                {
                    String FilePath = "";
                    if (UploadCoverimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/EventCover/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/EventCover/" + UploadCoverimage.FileName;
                        UploadCoverimage.SaveAs(Server.MapPath(FilePath));

                    }
                    objvalue.CoverImage = FilePath;
                    objvalue.EventName = txtEventname.Text;
                    objvalue.Description = txtDescription.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.EventgalleryInsert(objvalue);
                    BindData();
                    ClearFormData();
                }
                else
                {
                    String FilePath = "";
                    if (UploadCoverimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/EventCover/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/EventCover/" + UploadCoverimage.FileName;
                        UploadCoverimage.SaveAs(Server.MapPath(FilePath));

                    }
                    else
                    {
                        FilePath = hnImagePath.Value;
                    }
                    objvalue.CoverImage = FilePath;
                    objvalue.EventID = Convert.ToInt32(hnId.Value);
                    objvalue.EventName = txtEventname.Text;
                    objvalue.Description = txtDescription.Text;
                    objvalue.UpdatedDate = DateTime.Now;

                    objinteraction.EventgalleryUpdate(objvalue);
                    BindData();
                    ClearFormData();
                    btnAddEvent.Text = "Add Event";
                }
            }
            catch (Exception)
            { }
        }
        private void ClearFormData()
        {
            txtEventname.Text = "";
            txtDescription.Text = "";
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.EventID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.Eventdelete(objvalue);
                    BindData();
                }
                if (e.CommandName == "Activate")
                {
                    objvalue.EventID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.Eventdelete(objvalue);
                    BindData();

                }
                if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.EventID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.EventgallerySelectById(objvalue);
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["CoverImage"].ToString();
                    hnImagePath.Value = ds.Tables[0].Rows[0]["CoverImage"].ToString();
                    txtEventname.Text = ds.Tables[0].Rows[0]["EventName"].ToString();
                    txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;
                    btnAddEvent.Text = "Update";


                }
            }
            catch (Exception)
            { }
        }

    }
}