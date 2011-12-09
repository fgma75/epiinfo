﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epi.Web.Common.DTO;
using System.Runtime.Serialization;

namespace Epi.Web.Common.Message
{
    [DataContract(Namespace = "http://www.yourcompany.com/types/")]
    public class PublishResponse : Epi.Web.Common.MessageBase.ResponseBase 
    {

        /// <summary>
        /// Default Constructor for PublishResponse.
        /// </summary>
        public PublishResponse() { }

        /// <summary>
        /// Overloaded Constructor for PublishResponse. Sets CorrelationId.
        /// </summary>
        /// <param name="correlationId"></param>
        public PublishResponse(string correlationId) : base(correlationId) { }


        /// <summary>
        /// PublishInfo object.
        /// </summary>
        [DataMember]
        public PublishInfoDTO PublishInfo;
    }
}
