//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usersetdefinition
    {
        public int Id { get; set; }
        public int Set_id { get; set; }
        public string Subversename { get; set; }
    
        public virtual Subverse Subvers { get; set; }
        public virtual Userset Userset { get; set; }
    }
}
