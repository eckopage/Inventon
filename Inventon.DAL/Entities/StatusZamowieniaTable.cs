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
    
    public partial class StatusZamowieniaTable
    {
        public StatusZamowieniaTable()
        {
            this.ZamowienieTable = new HashSet<ZamowienieTable>();
        }
    
        public int id { get; set; }
        public string StatusNazwa { get; set; }
        public string StatusOpis { get; set; }
    
        public virtual ICollection<ZamowienieTable> ZamowienieTable { get; set; }
    }
}
