//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tor4Me.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class service_executers
    {
        public long sexexeid { get; set; }
        public long sexbusid { get; set; }
        public long sexservid { get; set; }
        public string sexudf_text1 { get; set; }
        public string sexudf_text2 { get; set; }
        public string sexudf_text3 { get; set; }
        public string sexudf_text4 { get; set; }
        public string sexudf_text5 { get; set; }
        public int sexudf_integer1 { get; set; }
        public int sexudf_integer2 { get; set; }
        public int sexudf_integer3 { get; set; }
        public int sexudf_integer4 { get; set; }
        public int sexudf_integer5 { get; set; }
    
        public virtual executers executers { get; set; }
        public virtual service service { get; set; }
    }
}
