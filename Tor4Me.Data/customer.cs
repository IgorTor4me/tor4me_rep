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
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.orders = new HashSet<orders>();
        }
    
        public long cusid { get; set; }
        public long cusbusid { get; set; }
        public string cusname { get; set; }
        public string cuslastname { get; set; }
        public string cusphone { get; set; }
        public string cusemail { get; set; }
        public string cusudf_text1 { get; set; }
        public string cusudf_text2 { get; set; }
        public string cusudf_text3 { get; set; }
        public string cusudf_text4 { get; set; }
        public string cusudf_text5 { get; set; }
        public int cusudf_integer1 { get; set; }
        public int cusudf_integer2 { get; set; }
        public int cusudf_integer3 { get; set; }
        public int cusudf_integer4 { get; set; }
        public int cusudf_integer5 { get; set; }
    
        public virtual business business { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
