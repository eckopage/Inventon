//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventon.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProducentTable
    {
        public ProducentTable()
        {
            this.ProduktTable = new HashSet<ProduktTable>();
        }
    
        public int id { get; set; }
        public string ProducentNazwa { get; set; }
    
        public virtual ICollection<ProduktTable> ProduktTable { get; set; }
    }
}
