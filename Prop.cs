using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Prop
    {
        #region aboutus

        private Int32 _AID;
        public Int32 AID
        {
            get { return _AID; }
            set { _AID = value; }
        }


        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        private string _WCContent;
        public string WCContent
        {
            get { return _WCContent; }
            set { _WCContent = value; }
        }
        private string _Logo;
        public string Logo
        {
            get { return _Logo; }
            set { _Logo = value; }
        }
        private string _MissionVisionContent;
        public string MissionVisionContent
        {
            get { return _MissionVisionContent; }
            set { _MissionVisionContent = value; }
        }

        private string _Flag;
        public string Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        private DateTime _UpdatedDate;
        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        #endregion aboutus

        #region contactus

        private Int32 _CID;
        public Int32 CID
        {
            get { return _CID; }
            set { _CID = value; }
        }

        private string _CompanyLogo;
        public string CompanyLogo
        {
            get { return _CompanyLogo; }
            set { _CompanyLogo = value; }
        }
        private string _Streetname;
        public string Streetname
        {
            get { return _Streetname; }
            set { _Streetname = value; }
        }
        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        private string _State;
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        private string _Zipcode;
        public string Zipcode
        {
            get { return _Zipcode; }
            set { _Zipcode = value; }
        }
        private string _CompanyName;
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        private string _Contact1;
        public string Contact1
        {
            get { return _Contact1; }
            set { _Contact1 = value; }
        }
        private string _Contact2;
        public string Contact2
        {
            get { return _Contact2; }
            set { _Contact2 = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Timing;
        public string Timing 
        {
            get { return _Timing; }
            set { _Timing = value; }
        }
        private string _Map;
        public string Map
        {
            get { return _Map; }
            set { _Map = value;  }
        }


        #endregion contactus

        #region careervacancies

        private Int32 _CareerVacanciesID;
        public Int32 CareerVacanciesID
        {
            get { return _CareerVacanciesID; }
            set { _CareerVacanciesID = value; }
        }

        private string _Technology;
        public string Technology
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        private string _Post;
        public string Post
        {
            get { return _Post; }
            set { _Post = value; }
        }
        private Int32 _NumOfVacancies;
        public Int32 NumOfVacancies
        {
            get { return _NumOfVacancies; }
            set { _NumOfVacancies = value; }
        }
        private string _JobLocation;
        public string JobLocation
        {
            get { return _JobLocation; }
            set { _JobLocation = value; }
        }
        private string _Qualification;
        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
        private string _RequiredSkills;
        public string RequiredSkills
        {
            get { return _RequiredSkills; }
            set { _RequiredSkills = value; }
        }
        private string _ExtraContent;
        public string ExtraContent
        {
            get { return _ExtraContent; }
            set { _ExtraContent = value; }
        }


        #endregion careervacancies

        #region eventgallery

        private Int32 _EventID;
        public Int32 EventID
        {
            get { return _EventID; }
            set { _EventID = value; }
        }
        private string _EventName;
        public string EventName
        {
            get { return _EventName; }
            set { _EventName = value; }
        }
        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        
       #endregion eventgallery

        #region EventImages
        private Int32 _EventImageID;
        public Int32 EventImageID
        {
            get { return _EventImageID; }
            set { _EventImageID = value; }
        }

        #endregion EventImages

        #region sliderImages
        private Int32 _SliderID;
        public Int32 SliderID
        {
            get { return _SliderID; }
            set { _SliderID = value; }
        }
        private string _SliderTitle;
        public string SliderTitle
        {
            get { return _SliderTitle; }
            set { _SliderTitle = value; }
        }
        private string _SliderDescription;
        public string SliderDescription
        {
            get { return _SliderDescription; }
            set { _SliderDescription = value; }
        }


        #endregion sliderimages

        #region faq

        private Int32 _FaqID;
        public Int32 FaqID
        {
            get { return _FaqID; }
            set { _FaqID = value; }
        }

        private string _Question;
        public string Question
        {
            get { return _Question; }
            set { _Question = value; }
        }
        private string _Answer;
        public string Answer
        {
            get { return _Answer; }
            set { _Answer = value; }
        }

        #endregion faq

        #region testimonial

        private Int32 _TestimonialID;
        public Int32 TestimonialID
        {
            get { return _TestimonialID; }
            set { _TestimonialID = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Testimonial;
        public string Testimonial
        {
            get { return _Testimonial; }
            set { _Testimonial = value; }
        }

        #endregion testimonial

        #region userprofile

        private Int32 _UserProfileID;
        public Int32 UserProfileID
        {
            get { return _UserProfileID; }
            set { _UserProfileID = value; }
        }
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _NewPassword;
        public string NewPassword
        {
            get { return _NewPassword; }
            set { _NewPassword = value; }
        }
        private string _Contact;
        public string Contact
        {
            get { return _Contact; }
            set { _Contact = value; }
        }
        
        #endregion userprofile

        #region login

        private Int32 _LID;
        public Int32 LID
        {
            get { return _LID; }
            set { _LID = value; }
        }

        #endregion login

        #region Enquiry
        private Int32 _EnquiryID;
        public Int32 EnquiryID
        {
            get { return _EnquiryID; }
            set { _EnquiryID = value; }
        }
        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }

        }
        private string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        private string _Message;
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        #endregion Enquiry

        #region Newsletter

        private Int32 _NewsLetterID;
        public Int32 NewsLetterID
        {
            get { return _NewsLetterID; }
            set { _NewsLetterID = value; }
        }

        #endregion newsletter

        #region Portfolio
        private Int32 _PortfolioID;
        public Int32 PortfolioID
        {
            get { return _PortfolioID; }
            set { _PortfolioID = value; }
        }
        private string _CoverImage;
        public string CoverImage
        {
            get { return _CoverImage; }
            set { _CoverImage = value; }
        }


        #endregion portfolio

        #region socialmediainfo

        private Int32 _SocialMediaID;
        public Int32 SocialMediaID
        {
            get { return _SocialMediaID; }
            set { _SocialMediaID = value; }
        }
        private string _FacebookURL;
        public string FacebookURL
        {
            get { return _FacebookURL; }
            set { _FacebookURL = value; }
        }
        private string _TwitterURL;
        public string TwitterURL
        {
            get { return _TwitterURL; }
            set { _TwitterURL = value; }
        }
        private string _LinkedinURL;
        public string LinkedinURL
        {
            get { return _LinkedinURL; }
            set { _LinkedinURL = value; }
        }

        #endregion socialmediainfo

        #region Category

        private string _CategoryName;
        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }
        private string _CategoryImage;
        public string CategoryImage
        {
            get { return _CategoryImage; }
            set { _CategoryImage = value; }
        }
        private string _CategoryDetail;
        public string CategoryDetail
        {
            get { return _CategoryDetail; }
            set { _CategoryDetail = value; }
        }

        #endregion

        #region SubCategory

        private string _SubCategoryName;
        public string SubCategoryName
        {
            get { return _SubCategoryName; }
            set { _SubCategoryName = value; }
        }

        private string _SubCategoryImage;
        public string SubCategoryImage
        {
            get { return _SubCategoryImage; }
            set { _SubCategoryImage = value; }
        }
        private string _SubCategoryDetail;
        public string SubCategoryDetail
        {
            get { return _SubCategoryDetail; }
            set { _SubCategoryDetail = value; }
        }

        #endregion

        #region Product

        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        private string _ProductImage;
        public string ProductImage
        {
            get { return _ProductImage; }
            set { _ProductImage = value; }
        }
        private Decimal _ProductPrice;
        public Decimal ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }
        private string _ProductDetail;
        public string ProductDetail
        {
            get { return _ProductDetail; }
            set { _ProductDetail = value; }
        }

        #endregion

   
      }
}