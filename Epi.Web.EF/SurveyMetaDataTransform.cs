//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyMetaDataTransform
    {
        public System.Guid SurveyId { get; set; }
        public string TableName { get; set; }
        public Nullable<int> PageId { get; set; }
        public string FieldName { get; set; }
        public int FieldTypeId { get; set; }
        public string BaseTableName { get; set; }
    
        public virtual SurveyMetaData SurveyMetaData { get; set; }
    }
}