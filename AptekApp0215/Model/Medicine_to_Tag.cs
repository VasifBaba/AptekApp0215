//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AptekApp0215.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine_to_Tag
    {
        public int ID { get; set; }
        public Nullable<int> Medicine_ID { get; set; }
        public Nullable<int> Tag_ID { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
