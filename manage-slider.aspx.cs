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
    public partial class manage_slider : System.Web.UI.Page
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
                ds = objinteraction.SliderImagesSelectAll();
                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void BtnSliderImage1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnSliderImage1.Text == "Add Image")
                {
                    String FilePath = "";
                    if (UploadSliderimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/SliderImages/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/SliderImages/" + UploadSliderimage.FileName;
                        UploadSliderimage.SaveAs(Server.MapPath(FilePath));

                    }
                    objvalue.ImagePath = FilePath;
                    objvalue.SliderTitle = txtSlidertitle.Text;
                    objvalue.SliderDescription = txtsliderdes.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.SliderImagesInsert(objvalue);
                    BindData();
                }
                else
                {
                    String FilePath1 = "";
                    if (UploadSliderimage.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/SliderImages/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "/images/SliderImages/" + UploadSliderimage.FileName;
                        UploadSliderimage.SaveAs(Server.MapPath(FilePath1));

                    }
                    else
                    {
                        FilePath1 = Hnfd.Value;
                    }
                    objvalue.SliderID = Convert.ToInt32(hnId.Value);
                    objvalue.ImagePath = FilePath1;
                    objvalue.SliderTitle = txtSlidertitle.Text;
                    objvalue.SliderDescription = txtsliderdes.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.SliderImagesUpdate(objvalue);
                    BindData();
                    BtnSliderImage1.Text = "Add Image";

                }
            }
            catch (Exception)
            { }
        }
       

        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.SliderID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.SliderImageDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.SliderID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.SliderImageDelete(objvalue);
                    BindData();

                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.SliderID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.SliderImagesSelectById(objvalue);
                    txtSlidertitle.Text = ds.Tables[0].Rows[0]["SliderTitle"].ToString();
                    txtsliderdes.Text = ds.Tables[0].Rows[0]["SliderDescription"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;
                    BtnSliderImage1.Text = "Update";

                }
            }
            catch (Exception)
            { }

        }


    }
}