//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S00213942ProjectOOD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fork
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ForkImage { get; set; }
        public int FrameId { get; set; }
    
        public virtual Frame Frame { get; set; }
    }
}
