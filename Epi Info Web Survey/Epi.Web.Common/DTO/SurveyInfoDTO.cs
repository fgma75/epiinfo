﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Epi.Web.Common.DTO
{
    [DataContract(Namespace = "http://www.yourcompany.com/types/")]
    public class SurveyInfoDTO 
    {
        private string _SurveyId;
        private string _SurveyNumber;
        private string _SurveyName;
        private int _SurveyType;
        private string _IntroductionText;
        private string _ExitText;
        private string _DepartmentName;
        private string _OrganizationName;
        private string _XML;
        private bool _IsSuccess;
        private DateTime _ClosingDate;
        private Guid _UserPublishKey;
        private Guid _OrganizationKey;
        private DateTime _StartDate;
        private  string _LogoURL;
        private string _LogoLocation;
        private bool _TestMode;
        [DataMember]
        public string SurveyId
        {
            get { return _SurveyId; }
            set { _SurveyId = value; }
        }
        [DataMember]
        public string SurveyNumber
        {
            get { return _SurveyNumber; }
            set { _SurveyNumber = value; }
        }

        [DataMember]
        public string SurveyName
        {
            get { return _SurveyName; }
            set { _SurveyName = value; }
        }

        [DataMember]
        public int SurveyType
        {
            get { return _SurveyType; }
            set { _SurveyType = value; }
        }

        [DataMember]
        public string OrganizationName
        {
            get { return _OrganizationName; }
            set { _OrganizationName = value; }
        }

        [DataMember]
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }


        [DataMember]
        public string IntroductionText
        {
            get { return _IntroductionText; }
            set { _IntroductionText = value; }
        }

        [DataMember]
        public string ExitText
        {
            get { return _ExitText; }
            set { _ExitText = value; }
        }

        [DataMember]
        public string XML
        {
            get { return _XML; }
            set { _XML = value; }
        }
        [DataMember]
        public bool IsSuccess
        {
            get { return _IsSuccess; }
            set { _IsSuccess = value; }
        }

        [DataMember]
        public DateTime ClosingDate
        {
            get { return _ClosingDate; }
            set { _ClosingDate = value; }
        }
       
        [DataMember]
        public Guid UserPublishKey
        {
            get { return _UserPublishKey; }
            set { _UserPublishKey = value; }
        }

        [DataMember]
        public Guid OrganizationKey
        {
            get { return _OrganizationKey; }
            set { _OrganizationKey = value; }
        }
          [DataMember]
          public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
          [DataMember]
        public string LogoURL
        {
            get { return _LogoURL; }
            set { _LogoURL = value; }
        }
          [DataMember]
        public string LogoLocation
        {
            get { return _LogoLocation; }
            set { _LogoLocation = value; }
        }
          [DataMember]
        public bool TestMode
        {
            get { return _TestMode; }
            set { _TestMode = value; }
        }
    
    }
}
