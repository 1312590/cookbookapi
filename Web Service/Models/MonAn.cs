//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Service.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonAn
    {
        public MonAn()
        {
            this.BinhLuan = new HashSet<BinhLuan>();
            this.Thich = new HashSet<Thich>();
        }
    
        public int MaMonAn { get; set; }
        public string TenMon { get; set; }
        public string GioiThieu { get; set; }
        public string Hinh { get; set; }
        public Nullable<int> ThoiGianChuanBi { get; set; }
        public Nullable<int> ThoiGianNau { get; set; }
        public Nullable<System.DateTime> NgayDang { get; set; }
        public string NguyenLieu { get; set; }
        public string CachLam { get; set; }
        public string MaNguoiDung { get; set; }
        public int MaMucDo { get; set; }
        public int MaLoaiMon { get; set; }
    
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual MucDo MucDo { get; set; }
        public virtual LoaiMon LoaiMon { get; set; }
        public virtual ICollection<Thich> Thich { get; set; }
    }
}
