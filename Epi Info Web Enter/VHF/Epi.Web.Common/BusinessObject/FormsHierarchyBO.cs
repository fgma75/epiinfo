﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Epi.Web.Enter.Common.BusinessObject
    {
    [DataContract(Namespace = "http://www.yourcompany.com/types/")]
    public class FormsHierarchyBO
        {
        private string _FormId;
        private List<SurveyResponseBO> _ResponseIds;
        private bool _IsRoot;
        private int _ViewId;
        [DataMember]
        public string FormId
            {
            get { return _FormId; }
            set { _FormId = value; }
            }
        [DataMember]
        public List<SurveyResponseBO> ResponseIds
            {
            get { return _ResponseIds; }
            set { _ResponseIds = value; }
            }
        [DataMember]
        public bool IsRoot
            {
            get { return _IsRoot; }
            set { _IsRoot = value; }
            }
        [DataMember]
        public int ViewId
            {
            get { return _ViewId; }
            set { _ViewId = value; }
            }
        }
    }