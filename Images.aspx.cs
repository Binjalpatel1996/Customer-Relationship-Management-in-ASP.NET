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
    public partial class Images : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllEventNames();
                BindRepeater();
            }

        }

        private void BindRepeater()
        {
            try
            {
                ds = objinteraction.EventImagesSelectAll();

                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch (Exception)
            { }
        }
        protected void LoadAllEventNames()
        {
            try
            {
                ds = objinteraction.EventgallerySelect();
                DdlEventname.DataTextField = "EventName";
                DdlEventname.DataValueField = "EventID";
                DdlEventname.DataSource = ds;
                DdlEventname.DataBind();
            }
            catch (Exception)
            { }
        }

        protected void BtnAddimages_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnAddimages.Text == "Add image")
                {
                    String FilePath = "";
                    if (UploadEventimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/Event/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/Event/" + UploadEventimage.FileName;
                        UploadEventimage.SaveAs(Server.MapPath(FilePath));

                    }

                    objvalue.EventName = DdlEventname.SelectedItem.Text;
                    objvalue.EventID = Convert.ToInt32(DdlEventname.SelectedValue);
                    objvalue.ImagePath = FilePath;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.EventImagesInsert(objvalue);
                    BindRepeater();
                }
                else
                {
                    String FilePath1 = "";
                    if (UploadEventimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/Event/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "/images/Event/" + UploadEventimage.FileName;
                        UploadEventimage.SaveAs(Server.MapPath(FilePath1));

                    }
                    else
                    {
                        FilePath1 = hnfd.Value;

                    }

                    objvalue.EventImageID = Convert.ToInt32(hnId.Value);
                    objvalue.EventName = DdlEventname.SelectedItem.Text;
                    objvalue.EventID = Convert.ToInt32(DdlEventname.SelectedValue);
                    objvalue.ImagePath = FilePath1;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.EventImagesUpdate(objvalue);
                    BindRepeater();
                    ClearFormData();
                    BtnAddimages.Text = "Add image";
                }
            }
            catch (Exception)
            { }

        }

        private void ClearFormData()
        {
            DdlEventname.SelectedItem.Text = "----- Select Event Name -----";
            Image1.ImageUrl = "";
        }

        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.EventImageID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.EventimageDelete(objvalue);
                    BindRepeater();
                }
                if (e.CommandName == "Activate")
                {
                    objvalue.EventImageID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.EventimageDelete(objvalue);
                    BindRepeater();
                }
                if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.EventImageID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.EventImageSelectById(objvalue);
                    DdlEventname.SelectedItem.Text = ds.Tables[0].Rows[0]["EventName"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    hnfd.Value = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;
                    BtnAddimages.Text = "Update";
                }
            }
            catch (Exception)
            { }
        }
    }
}