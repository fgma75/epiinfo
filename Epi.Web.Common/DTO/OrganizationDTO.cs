﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Epi.Web.Common.DTO
{
    public class OrganizationDTO
    {
        private string _Organization;
        private Guid _OrganizationKey;
        private bool _IsEnabled;
        private Guid _AdminId;

        public string Organization
        {
            get { return _Organization; }
            set { _Organization = value; }
        }

        public Guid OrganizationKey 
        {
            get { return _OrganizationKey; }
            set { _OrganizationKey = value; }
        }
        public Guid AdminId
        {
            get { return _AdminId; }
            set { _AdminId = value; }
        }

        public bool IsEnabled
        {
            get { return _IsEnabled; }
            set { _IsEnabled = value; }
        }


    }
}
