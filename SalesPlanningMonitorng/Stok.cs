//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesPlanningMonitorng
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stok
    {
        public int id_barang { get; set; }
        public int id_toko { get; set; }
        public short jumlah { get; set; }
    
        public virtual Barang Barang { get; set; }
        public virtual Toko Toko { get; set; }
    }
}
