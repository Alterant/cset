//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARAMETER_ASSESSMENT
    {
        public int Parameter_ID { get; set; }
        public int Assessment_ID { get; set; }
        public string Parameter_Value_Assessment { get; set; }
    
        public virtual ASSESSMENT ASSESSMENT { get; set; }
        public virtual PARAMETER PARAMETER { get; set; }
    }
}

