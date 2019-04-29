using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class InteractionMethod
    {
        DataSet ds = new DataSet();
        DBInteraction di = new DBInteraction();

        #region aboutus

        public void AboutInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[2] = new SqlParameter("@WCContent", objValue.WCContent);
            Para[3] = new SqlParameter("@MissionVisionContent", objValue.MissionVisionContent);
            Para[4] = new SqlParameter("@Flag", objValue.Flag);
            Para[5] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            di.ExecQryPara("SP_tblAboutUs", Para);
        }
        public void AboutUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[2] = new SqlParameter("@WCContent", objValue.WCContent);
            Para[3] = new SqlParameter("@MissionVisionContent", objValue.MissionVisionContent);
            Para[4] = new SqlParameter("@AID", objValue.AID);
            Para[5] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);

            di.ExecQryPara("SP_tblAboutUs", Para);
        }
        public DataSet AboutusSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblAboutUs", Para);
            return ds;
        }
        public void AboutDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@AID", objValue.AID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
       //     Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.ExecQryPara("SP_tblAboutUs", Para);
        }
        public DataSet AboutSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@AID", objValue.AID);
            ds = di.GetDataPara("SP_tblAboutUs", Para);
            return ds;
        }

        #endregion aboutus

        #region contactus

        public void ContactInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[15];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@CompanyLogo", objValue.CompanyLogo);
            Para[2] = new SqlParameter("@Streetname", objValue.Streetname);
            Para[3] = new SqlParameter("@CompanyName", objValue.CompanyName);
            Para[4] = new SqlParameter("@City", objValue.City);
            Para[5] = new SqlParameter("@Contact1", objValue.Contact1);
            Para[6] = new SqlParameter("@Zipcode", objValue.Zipcode);
            Para[7] = new SqlParameter("@Email", objValue.Email);
            Para[8] = new SqlParameter("@Timing", objValue.Timing);
            Para[9] = new SqlParameter("@Map", objValue.Map);
            Para[10] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[11] = new SqlParameter("@Flag", objValue.Flag);
            Para[12] = new SqlParameter("@State",objValue.State);
            Para[13] = new SqlParameter("@Country",objValue.Country);
            Para[14] = new SqlParameter("@Contact2",objValue.Contact2);

            di.ExecQryPara("SP_tblContactUs", Para);
        }
        public void ContactUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[15];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@CompanyLogo", objValue.CompanyLogo);
            Para[2] = new SqlParameter("@Streetname", objValue.Streetname);
            Para[3] = new SqlParameter("@CompanyName", objValue.CompanyName);
            Para[4] = new SqlParameter("@City", objValue.City);
            Para[5] = new SqlParameter("@Contact1", objValue.Contact1);
            Para[6] = new SqlParameter("@Zipcode", objValue.Zipcode);
            Para[7] = new SqlParameter("@Email", objValue.Email);
            Para[8] = new SqlParameter("@Timing", objValue.Timing);
            Para[9] = new SqlParameter("@Map", objValue.Map);
            Para[10] = new SqlParameter("@CID", objValue.CID);
            Para[11] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[12] = new SqlParameter("@State", objValue.State);
            Para[13] = new SqlParameter("@Country", objValue.Country);
            Para[14] = new SqlParameter("@Contact2", objValue.Contact2);


            di.ExecQryPara("SP_tblContactUs", Para);
        }
        public DataSet ContactUsSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblContactUs", Para);
            return ds;
        }
        public void ContactDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@CID", objValue.CID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
//          Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblContactUs", Para);
        }
        public DataSet ContactSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@CID", objValue.CID);
            ds = di.GetDataPara("SP_tblContactUs", Para);
            return ds;
        }
       


        #endregion contactus

        #region careervacancies

        public void CareerInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[10];
            Para[0] = new SqlParameter("@MOde", "insert");
            Para[1] = new SqlParameter("@Technology", objValue.Technology);
            Para[2] = new SqlParameter("@Post", objValue.Post);
            Para[3] = new SqlParameter("@NumOfVacancies", objValue.NumOfVacancies);
            Para[4] = new SqlParameter("@JobLocation", objValue.JobLocation);
            Para[5] = new SqlParameter("@Qualification", objValue.Qualification);
            Para[6] = new SqlParameter("@RequiredSkills", objValue.RequiredSkills);
            Para[7] = new SqlParameter("@ExtraContent", objValue.ExtraContent);
            Para[8] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[9] = new SqlParameter("@Flag", objValue.Flag);
            di.ExecQryPara("SP_tblCareerVacancies", Para);
        }
        public void CareerUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[10];
            Para[0] = new SqlParameter("@MOde", "Update");

            Para[1] = new SqlParameter("@Technology", objValue.Technology);
            Para[2] = new SqlParameter("@Post", objValue.Post);
            Para[3] = new SqlParameter("@NumOfVacancies", objValue.NumOfVacancies);
            Para[4] = new SqlParameter("@JobLocation", objValue.JobLocation);
            Para[5] = new SqlParameter("@Qualification", objValue.Qualification);
            Para[6] = new SqlParameter("@RequiredSkills", objValue.RequiredSkills);
            Para[7] = new SqlParameter("@ExtraContent", objValue.ExtraContent);
            Para[8] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[9] = new SqlParameter("@CareerVacanciesID", objValue.CareerVacanciesID);
          


            di.ExecQryPara("SP_tblCareerVacancies", Para);
        }

        public DataSet CareerSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblCareerVacancies", Para);
            return ds;
        }
        public DataSet CareerSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@CareerVacanciesID", objValue.CareerVacanciesID);
            ds = di.GetDataPara("SP_tblCareerVacancies", Para);
            return ds;
        }
        public void CareerDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[4];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@CareerVacanciesID", objValue.CareerVacanciesID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
            Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblCareerVacancies", Para);
        }

        #endregion careervacancies

        #region eventgallery

        public void EventgalleryInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@EventName", objValue.EventName);

            Para[2] = new SqlParameter("@Description", objValue.Description);
            Para[3] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[4] = new SqlParameter("@Flag", objValue.Flag);
            Para[5] = new SqlParameter("@CoverImage", objValue.CoverImage);
            di.ExecQryPara("SP_tblEventGallery", Para);
        }
        public void EventgalleryUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@EventName", objValue.EventName);
            Para[2] = new SqlParameter("@Description", objValue.Description);
            Para[3] = new SqlParameter("@EventID", objValue.EventID);
            Para[4] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[5] = new SqlParameter("@CoverImage", objValue.CoverImage);
            di.ExecQryPara("SP_tblEventGallery", Para);
        }
        public DataSet EventgallerySelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblEventGallery", Para);
            return ds;
        }
        public DataSet EventgallerySelect()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "select");
            ds = di.GetDataPara("SP_tblEventGallery", Para);
            return ds;
        }
        public DataSet EventgallerySelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@EventID", objValue.EventID);
            ds = di.GetDataPara("SP_tblEventGallery", Para);
            return ds;
        }
        public void Eventdelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@EventID", objValue.EventID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
       //     Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblEventGallery", Para);
        }

        #endregion eventgalley

        #region eventimages

        public void EventImagesInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@EventName", objValue.EventName);
            Para[2] = new SqlParameter("@EventID", objValue.EventID);
            Para[3] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[4] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[5] = new SqlParameter("@Flag", objValue.Flag);
            di.ExecQryPara("SP_tblEventImages", Para);
        }

        public void EventImagesUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@EventName", objValue.EventName);
            Para[2] = new SqlParameter("@EventID", objValue.EventID);
            Para[3] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[4] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[5] = new SqlParameter("@EventImageID", objValue.EventImageID);
            di.ExecQryPara("SP_tblEventImages", Para);

        }
        public DataSet EventImageSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@EventImageID", objValue.EventImageID);
            ds = di.GetDataPara("SP_tblEventImages", Para);
            return ds;
        }
        public DataSet EventImageSelectByEventId(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectByEventId");
            Para[1] = new SqlParameter("@EventID", objValue.EventID);
            ds = di.GetDataPara("SP_tblEventImages", Para);
            return ds;
        }


        public DataSet EventImagesSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblEventImages", Para);
            return ds;
        }
        public void EventimageDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@EventImageID", objValue.EventImageID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
           // Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblEventImages", Para);
        }



        #endregion eventimages

        #region sliderimages

        public void SliderImagesInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[2] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[3] = new SqlParameter("@Flag", objValue.Flag);
            Para[4] = new SqlParameter("@SliderTitle",objValue.SliderTitle);
            Para[5] = new SqlParameter("@SliderDescription",objValue.SliderDescription);
            di.ExecQryPara("SP_tblSliderImages", Para);
        }
        public void SliderImagesUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[7];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@ImagePath", objValue.ImagePath);
            Para[2] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[3] = new SqlParameter("@Flag", objValue.Flag);
            Para[4] = new SqlParameter("@SliderID",objValue.SliderID);
            Para[5] = new SqlParameter("@SliderTitle", objValue.SliderTitle);
            Para[6] = new SqlParameter("@SliderDescription", objValue.SliderDescription);
            di.ExecQryPara("SP_tblSliderImages", Para);

        }
        public DataSet SliderImagesSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblSliderImages", Para);
            return ds;
        }
        public DataSet SliderImagesSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@SliderID", objValue.SliderID);
            ds = di.GetDataPara("SP_tblSliderImages", Para);
            return ds;
        }
        public void SliderImageDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@SliderID", objValue.SliderID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
        //    Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblSliderImages", Para);
        }

        #endregion sliderimages

        #region faq

        public void FaqInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "insert");
            Para[1] = new SqlParameter("@Question", objValue.Question);
            Para[2] = new SqlParameter("@Answer", objValue.Answer);
            Para[3] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[4] = new SqlParameter("@Flag", objValue.Flag);
            di.ExecQryPara("SP_tblFaq", Para);
        }
        public void FaqUpdate(Prop objValue)
        {

            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@Question", objValue.Question);
            Para[2] = new SqlParameter("@Answer", objValue.Answer);
            Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[4] = new SqlParameter("@FaqID",objValue.FaqID);
            di.ExecQryPara("SP_tblFaq", Para);


        }
        public DataSet FaqSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblFaq", Para);
            return ds;
        }
        public void FaqDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@FaqID", objValue.FaqID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
        //    Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblFaq", Para);
        }
        public DataSet FaqSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@FaqID", objValue.FaqID);
            ds = di.GetDataPara("SP_tblFaq", Para);
            return ds;
        }

        #endregion faq

        #region Testimonial

        public void TestimonialInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "insert");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Testimonial", objValue.Testimonial);
            Para[3] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[4] = new SqlParameter("@Flag", objValue.Flag);
            di.ExecQryPara("SP_tblTestimonial", Para);
        }
        public void TestimonialUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Testimonial", objValue.Testimonial);
            Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[4] = new SqlParameter("@TestimonialID", objValue.TestimonialID);
            di.ExecQryPara("SP_tblTestimonial", Para);


        }
        public DataSet TestimonialSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblTestimonial", Para);
            return ds;
        }
        public DataSet TestimonialSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@TestimonialID", objValue.TestimonialID);
            ds = di.GetDataPara("SP_tblTestimonial", Para);
            return ds;
        }
        public void TestimonialDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@TestimonialID", objValue.TestimonialID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
          //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblTestimonial", Para);
        }

        #endregion Testimonial

        #region userprofile

        public void userInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[9];
            Para[0] = new SqlParameter("@Mode", "Insert");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Username", objValue.Username);
            Para[3] = new SqlParameter("@Password", objValue.Password);
            Para[4] = new SqlParameter("@Contact", objValue.Contact);
            Para[5] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[6] = new SqlParameter("@Flag",objValue.Flag);
            Para[7] = new SqlParameter("@Email",objValue.Email);
            Para[8] = new SqlParameter("@ImagePath", objValue.ImagePath);
            di.ExecQryPara("SP_tblUserProfile", Para);
        }
        public void userUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[9];
            Para[0] = new SqlParameter("@Mode", "Update");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Username", objValue.Username);
            Para[3] = new SqlParameter("@Password", objValue.Password);
            Para[4] = new SqlParameter("@Contact", objValue.Contact);
            Para[5] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[6] = new SqlParameter("@Email", objValue.Email);
            Para[7] = new SqlParameter("@ImagePath",objValue.ImagePath);
            Para[8] = new SqlParameter("@UserProfileID", objValue.UserProfileID);
           
            di.ExecQryPara("SP_tblUserProfile", Para);

        }
        public DataSet userSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@Mode", "SelectAll");
            ds = di.GetDataPara("SP_tblUserProfile", Para);
            return ds;
        }
        public DataSet userSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@UserProfileID", objValue.UserProfileID);
            ds = di.GetDataPara("SP_tblUserProfile", Para);
            return ds;
        }
        public void userDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@UserProfileID", objValue.UserProfileID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
            //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblUserProfile", Para);
        }

        #endregion userprofile

        #region login

        public DataSet CheckLogin(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Login");
            Para[1] = new SqlParameter("@Username", objValue.Username);
            Para[2] = new SqlParameter("@Password", objValue.Password);
            ds = di.GetDataPara("SP_tblLogin", Para);
            return ds;
        }

        public void Updatepassword(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[4];
            Para[0] = new SqlParameter("@MOde", "Updatepassword");
            Para[1] = new SqlParameter("@Username", objValue.Username);
            Para[2] = new SqlParameter("@Password", objValue.Password);
            Para[3] = new SqlParameter("@NewPassword", objValue.NewPassword);
            di.ExecQryPara("SP_tblLogin", Para);
        }

        public void loginInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[4];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@Username", objValue.Username);
            Para[2] = new SqlParameter("@Password", objValue.Password);
            Para[3] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            di.ExecQryPara("SP_tblLogin", Para);
        }
        public DataSet loginSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblLogin", Para);
            return ds;
        }

        #endregion login

        #region Enquiry

        public void EnquiryInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[8];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Email", objValue.Email);
            Para[3] = new SqlParameter("@Phone", objValue.Phone);
            Para[4] = new SqlParameter("@Subject", objValue.Subject);
            Para[5] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[6] = new SqlParameter("@Flag", objValue.Flag);
            Para[7] = new SqlParameter("@Message",objValue.Message);
            di.ExecQryPara("SP_tblEnquiry", Para);
        }
        public void EnquiryUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[8];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@Email", objValue.Email);
            Para[3] = new SqlParameter("@Phone", objValue.Phone);
            Para[4] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[5] = new SqlParameter("@EnquiryID", objValue.EnquiryID);
            Para[6] = new SqlParameter("@Subject" ,objValue.Subject);
            Para[7] = new SqlParameter("@Message", objValue.Message);
            di.ExecQryPara("SP_tblEnquiry", Para);
        }
        public DataSet EnquirySelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblEnquiry", Para);
            return ds;
        }
        public DataSet EnquirySelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@EnquiryID", objValue.EnquiryID);
            ds = di.GetDataPara("SP_tblEnquiry", Para);
            return ds;
        }
        public void EnquiryDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@EnquiryID", objValue.EnquiryID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
            //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblEnquiry", Para);
        }
        #endregion Enquiry

        #region NewsLetter

        public void NewsLetterInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[4];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@Email", objValue.Email);
            Para[2] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[3] = new SqlParameter("@Flag", objValue.Flag);
            di.ExecQryPara("SP_tblNewsLetter", Para);
        }

        public DataSet NewsLetterSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblNewsLetter", Para);
            return ds;
        }

        public void NewsLetterDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@NewsLetterID", objValue.NewsLetterID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
            //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblNewsLetter", Para);
        }

        #endregion newsletter

        #region portfolio

        public void PortfolioInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@CoverImage", objValue.CoverImage);
            Para[3] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[4] = new SqlParameter("@Flag", objValue.Flag);
           
            di.ExecQryPara("SP_tblPortfolio", Para);
        }
        public void PortfolioUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[5];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@Name", objValue.Name);
            Para[2] = new SqlParameter("@CoverImage", objValue.CoverImage);
            Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[4] = new SqlParameter("@PortfolioID", objValue.PortfolioID);
            
            di.ExecQryPara("SP_tblPortfolio", Para);
        }
        public DataSet PortfolioSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblPortfolio", Para);
            return ds;
        }
        public DataSet PortfolioSelectById(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[2];
            Para[0] = new SqlParameter("@MOde", "SelectById");
            Para[1] = new SqlParameter("@PortfolioID", objValue.PortfolioID);
            ds = di.GetDataPara("SP_tblPortfolio", Para);
            return ds;
        }
        public void PortfolioDelete(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] = new SqlParameter("@MOde", "Delete");
            Para[1] = new SqlParameter("@PortfolioID", objValue.PortfolioID);
            Para[2] = new SqlParameter("@Flag", objValue.Flag);
            //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            di.GetDataPara("SP_tblPortfolio", Para);
        }
        public DataSet CountSelectedDashboard()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "CountSelected");
            ds = di.GetDataPara("SP_tblPortfolio", Para);
            return ds;
        }
        #endregion portfolio

        #region Socialmediainfo

        public void socialmediaInsert(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Insert");
            Para[1] = new SqlParameter("@FaceboolURL", objValue.FacebookURL);
            Para[2] = new SqlParameter("@TwitterURL", objValue.TwitterURL);
            Para[3] = new SqlParameter("@LinkedinURL",objValue.LinkedinURL);
            Para[4] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
            Para[5] = new SqlParameter("@Flag", objValue.Flag);

            di.ExecQryPara("SP_tblSocialMediaInfo", Para);
        }
        public void socialmediaUpdate(Prop objValue)
        {
            SqlParameter[] Para = new SqlParameter[6];
            Para[0] = new SqlParameter("@MOde", "Update");
            Para[1] = new SqlParameter("@FaceboolURL", objValue.FacebookURL);
            Para[2] = new SqlParameter("@TwitterURL", objValue.TwitterURL);
            Para[3] = new SqlParameter("@LinkedinURL", objValue.LinkedinURL);
            Para[4] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
            Para[5] = new SqlParameter("@SocialMediaID", objValue.SocialMediaID);

            di.ExecQryPara("SP_tblSocialMediaInfo", Para);
        }
        public DataSet socialmediaSelectAll()
        {
            SqlParameter[] Para = new SqlParameter[1];
            Para[0] = new SqlParameter("@MOde", "SelectAll");
            ds = di.GetDataPara("SP_tblSocialMediaInfo", Para);
            return ds;
        }
        //public DataSet socialmediaSelectById(Prop objValue)
        //{
        //    SqlParameter[] Para = new SqlParameter[2];
        //    Para[0] = new SqlParameter("@MOde", "SelectById");
        //    Para[1] = new SqlParameter("@SocialMediaID", objValue.SocialMediaID);
        //    ds = di.GetDataPara("SP_tblSocialMediaInfo", Para);
        //    return ds;
        //}
        //public void SocialmediaDelete(Prop objValue)
        //{
        //    SqlParameter[] Para = new SqlParameter[3];
        //    Para[0] = new SqlParameter("@MOde", "Delete");
        //    Para[1] = new SqlParameter("@PortfolioID", objValue.PortfolioID);
        //    Para[2] = new SqlParameter("@Flag", objValue.Flag);
        //    //  Para[3] = new SqlParameter("@UpdatedDate", objValue.UpdatedDate);
        //    di.GetDataPara("SP_tblPortfolio", Para);
        //}

        #endregion socialmediainfo
        /*   
             public DataSet CategorySelectAll()
              {
                  SqlParameter[] Para = new SqlParameter[1];
                  Para[0] = new SqlParameter("@Mode", "SelectAll");
                  ds = di.GetDataPara("SP_tblAboutUs", Para);
                  return ds;
              }
             public void CategoryDelete(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[4];
                  Para[0] = new SqlParameter("@Mode", "Delete");
                  Para[1] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  Para[2] = new SqlParameter("@Flag", objValue.Flag);
                  Para[3] = new SqlParameter("@Updatedate", objValue.Updatedate);
                  di.GetDataPara("SPtblCategory", Para);           
              }
              public DataSet CategorySelectById(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[2];
                  Para[0] = new SqlParameter("@Mode", "SelectbyCategoryId");
                  Para[1] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  ds = di.GetDataPara("SPtblCategory", Para);
                  return ds;
              }
       
              #endregion

              #region aboutus

              public void AbousInser(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[5];
                  Para[0] = new SqlParameter("@Mode", "Insert");
                  Para[1] = new SqlParameter("@ImagePath", objValue.ImagePath);
                  Para[2] = new SqlParameter("@WCContent", objValue.WCContent);
                  Para[3] = new SqlParameter("@Flag", objValue.Flag);
                  Para[4] = new SqlParameter("@CreatedDate", objValue.CreatedDate);
                  di.ExecQryPara("SP_tblAboutUs", Para);
              }
            /*  public void SubCategoryUpdate(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[8];
                  Para[0] = new SqlParameter("@Mode", "Update");
                  Para[1] = new SqlParameter("@SubCategoryName", objValue.SubCategoryName);
                  Para[2] = new SqlParameter("@SubCategoryImage", objValue.SubCategoryImage);
                  Para[3] = new SqlParameter("@SubCategoryDetail", objValue.SubCategoryDetail);
                  Para[4] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  Para[5] = new SqlParameter("@Flag", objValue.Flag);
                  Para[6] = new SqlParameter("@UpdateDate", objValue.Updatedate);
                  Para[7] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  di.ExecQryPara("SPtblSubCategory", Para);
              }
              public DataSet SubCategorySelectAll()
              {
                  SqlParameter[] Para = new SqlParameter[1];
                  Para[0] = new SqlParameter("@Mode", "SelectAllSubCategory");
                  ds = di.GetDataPara("SPtblSubCategory", Para);
                  return ds;
              }
              public void SubCategoryDelete(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[4];
                  Para[0] = new SqlParameter("@Mode", "Delete");
                  Para[1] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  Para[2] = new SqlParameter("@Flag", objValue.Flag);
                  Para[3] = new SqlParameter("@Updatedate", objValue.Updatedate);            
                  di.GetDataPara("SPtblSubCategory", Para);
              }
              public DataSet SubCategorySelectById(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[2];
                  Para[0] = new SqlParameter("@Mode", "SelectbySubCategoryId");
                  Para[1] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  ds = di.GetDataPara("SPtblSubCategory", Para);
                  return ds;
              }
              public DataSet SubCategorySelectByCategoryId(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[2];
                  Para[0] = new SqlParameter("@Mode", "SelectByCategoryId");
                  Para[1] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  ds = di.GetDataPara("SPtblSubCategory", Para);
                  return ds;
              }

              #endregion

              #region Product

              public void ProductInsert(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[9];
                  Para[0] = new SqlParameter("@Mode", "ProductInsert");
                  Para[1] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  Para[2] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  Para[3] = new SqlParameter("@ProductName", objValue.ProductName);
                  Para[4] = new SqlParameter("@ProductImage", objValue.ProductImage);
                  Para[5] = new SqlParameter("@ProductPrice", objValue.ProductPrice);
                  Para[6] = new SqlParameter("@ProductDetail", objValue.ProductDetail);
                  Para[7] = new SqlParameter("@Flag", objValue.Flag);
                  Para[8] = new SqlParameter("@CreateDate", objValue.Createdate);
                  di.ExecQryPara("SPtblProduct", Para);
              }
              public void ProductUpdate(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[10];
                  Para[0] = new SqlParameter("@Mode", "ProductUpdate");
                  Para[1] = new SqlParameter("@CategoryId", objValue.CategoryId);
                  Para[2] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  Para[3] = new SqlParameter("@ProductName", objValue.ProductName);
                  Para[4] = new SqlParameter("@ProductImage", objValue.ProductImage);
                  Para[5] = new SqlParameter("@ProductPrice", objValue.ProductPrice);
                  Para[6] = new SqlParameter("@ProductDetail", objValue.ProductDetail);
                  Para[7] = new SqlParameter("@Flag", objValue.Flag);
                  Para[8] = new SqlParameter("@UpdateDate", objValue.Updatedate);
                  Para[9] = new SqlParameter("@ProductId", objValue.ProductId);
                  di.ExecQryPara("SPtblProduct", Para);
              }
              public DataSet SelectAllProduct()
              {
                  SqlParameter[] Para = new SqlParameter[1];
                  Para[0] = new SqlParameter("@Mode", "SelectAllProduct");
                  ds = di.GetDataPara("SPtblProduct", Para);
                  return ds;
              }
              public void ProductDelete(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[4];
                  Para[0] = new SqlParameter("@Mode", "ProductDelete");
                  Para[1] = new SqlParameter("@Flag", objValue.Flag);
                  Para[2] = new SqlParameter("@Updatedate", objValue.Updatedate);
                  Para[3] = new SqlParameter("@ProductId", objValue.ProductId);
                  di.GetDataPara("SPtblProduct", Para);
          
              }
              public DataSet SelectByProductId(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[2];
                  Para[0] = new SqlParameter("@Mode", "SelectByProductId");
                  Para[1] = new SqlParameter("@ProductId", objValue.ProductId);
                  ds = di.GetDataPara("SPtblProduct", Para);
                  return ds;
              }
              public DataSet SelectByProductSubCategoryId(Prop objValue)
              {
                  SqlParameter[] Para = new SqlParameter[2];
                  Para[0] = new SqlParameter("@Mode", "SelectBySubCategoryId");
                  Para[1] = new SqlParameter("@SubCategoryId", objValue.SubCategoryId);
                  ds = di.GetDataPara("SPtblProduct", Para);
                  return ds;
              }
              */



        
    }
}
