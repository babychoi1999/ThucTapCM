﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaitaplonAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class quanlithucungEntities1 : DbContext
    {
        public quanlithucungEntities1()
            : base("name=quanlithucungEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calamviec> Calamviecs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTDichVu> CTDichVus { get; set; }
        public virtual DbSet<CTHoaDon> CTHoaDons { get; set; }
        public virtual DbSet<CTNhapPhuKien> CTNhapPhuKiens { get; set; }
        public virtual DbSet<CTNhapThucPham> CTNhapThucPhams { get; set; }
        public virtual DbSet<CTNhapThuCung> CTNhapThuCungs { get; set; }
        public virtual DbSet<CTPHUKIEN> CTPHUKIENs { get; set; }
        public virtual DbSet<CTTHUCPHAM> CTTHUCPHAMs { get; set; }
        public virtual DbSet<CTUuDai> CTUuDais { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhuKien> LoaiPhuKiens { get; set; }
        public virtual DbSet<LoaiThucPham> LoaiThucPhams { get; set; }
        public virtual DbSet<LoaiThuCung> LoaiThuCungs { get; set; }
        public virtual DbSet<LuongTungThang> LuongTungThangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<phanquyen> phanquyens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PHUKIEN> PHUKIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THUCPHAM> THUCPHAMs { get; set; }
        public virtual DbSet<ThuCung> ThuCungs { get; set; }
        public virtual DbSet<ThuongPhat> ThuongPhats { get; set; }
        public virtual DbSet<UuDaiHD> UuDaiHDs { get; set; }
    
        [DbFunction("quanlithucungEntities1", "doanhthuthang")]
        public virtual IQueryable<doanhthuthang_Result> doanhthuthang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<doanhthuthang_Result>("[quanlithucungEntities1].[doanhthuthang](@thang, @nam)", thangParameter, namParameter);
        }
    
        [DbFunction("quanlithucungEntities1", "dstaikhoan")]
        public virtual IQueryable<dstaikhoan_Result> dstaikhoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dstaikhoan_Result>("[quanlithucungEntities1].[dstaikhoan]()");
        }
    
        [DbFunction("quanlithucungEntities1", "getmahd")]
        public virtual IQueryable<getmahd_Result> getmahd()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getmahd_Result>("[quanlithucungEntities1].[getmahd]()");
        }
    
        [DbFunction("quanlithucungEntities1", "HangTonKho")]
        public virtual IQueryable<HangTonKho_Result> HangTonKho(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HangTonKho_Result>("[quanlithucungEntities1].[HangTonKho](@thang, @nam)", thangParameter, namParameter);
        }
    
        [DbFunction("quanlithucungEntities1", "reportHoaDon")]
        public virtual IQueryable<reportHoaDon_Result> reportHoaDon(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<reportHoaDon_Result>("[quanlithucungEntities1].[reportHoaDon](@mahd)", mahdParameter);
        }
    
        [DbFunction("quanlithucungEntities1", "reportPhieuNhap")]
        public virtual IQueryable<reportPhieuNhap_Result> reportPhieuNhap(string mapn)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<reportPhieuNhap_Result>("[quanlithucungEntities1].[reportPhieuNhap](@mapn)", mapnParameter);
        }
    
        [DbFunction("quanlithucungEntities1", "thucungtonkho")]
        public virtual IQueryable<thucungtonkho_Result> thucungtonkho(Nullable<int> thang, Nullable<int> nam, string mathucung)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            var mathucungParameter = mathucung != null ?
                new ObjectParameter("mathucung", mathucung) :
                new ObjectParameter("mathucung", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<thucungtonkho_Result>("[quanlithucungEntities1].[thucungtonkho](@thang, @nam, @mathucung)", thangParameter, namParameter, mathucungParameter);
        }
    
        public virtual int deleHD(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleHD", mahdParameter);
        }
    
        public virtual int deletecalam(string maca)
        {
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletecalam", macaParameter);
        }
    
        public virtual int deleteKH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteKH", makhParameter);
        }
    
        public virtual int deleteNCC(string mancc)
        {
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNCC", manccParameter);
        }
    
        public virtual int deleteNhanVien(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNhanVien", manvParameter);
        }
    
        public virtual int deletePN(string mapn)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletePN", mapnParameter);
        }
    
        public virtual int deleteTP(string matp)
        {
            var matpParameter = matp != null ?
                new ObjectParameter("matp", matp) :
                new ObjectParameter("matp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteTP", matpParameter);
        }
    
        public virtual ObjectResult<DoanhThuTheoThang_Result> DoanhThuTheoThang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoanhThuTheoThang_Result>("DoanhThuTheoThang", thangParameter, namParameter);
        }
    
        public virtual ObjectResult<hdchuathanhtoan_Result> hdchuathanhtoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hdchuathanhtoan_Result>("hdchuathanhtoan");
        }
    
        public virtual ObjectResult<hddvchuathanhtoan_Result> hddvchuathanhtoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hddvchuathanhtoan_Result>("hddvchuathanhtoan");
        }
    
        public virtual ObjectResult<hdphukienchuathanhtoan_Result> hdphukienchuathanhtoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hdphukienchuathanhtoan_Result>("hdphukienchuathanhtoan");
        }
    
        public virtual ObjectResult<hdthucungchuathanhtoan_Result> hdthucungchuathanhtoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hdthucungchuathanhtoan_Result>("hdthucungchuathanhtoan");
        }
    
        public virtual ObjectResult<HoaDonPhieuNhap_Result> HoaDonPhieuNhap(string mapn)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HoaDonPhieuNhap_Result>("HoaDonPhieuNhap", mapnParameter);
        }
    
        public virtual int insertcalam(string tenca, string tgbd, string tgkt)
        {
            var tencaParameter = tenca != null ?
                new ObjectParameter("tenca", tenca) :
                new ObjectParameter("tenca", typeof(string));
    
            var tgbdParameter = tgbd != null ?
                new ObjectParameter("tgbd", tgbd) :
                new ObjectParameter("tgbd", typeof(string));
    
            var tgktParameter = tgkt != null ?
                new ObjectParameter("tgkt", tgkt) :
                new ObjectParameter("tgkt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertcalam", tencaParameter, tgbdParameter, tgktParameter);
        }
    
        public virtual int insertCTPK(string mapn, Nullable<int> soluong, Nullable<double> gianhap, string tenphukien, string maloai, byte[] anh, string donvi)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var gianhapParameter = gianhap.HasValue ?
                new ObjectParameter("gianhap", gianhap) :
                new ObjectParameter("gianhap", typeof(double));
    
            var tenphukienParameter = tenphukien != null ?
                new ObjectParameter("tenphukien", tenphukien) :
                new ObjectParameter("tenphukien", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var anhParameter = anh != null ?
                new ObjectParameter("anh", anh) :
                new ObjectParameter("anh", typeof(byte[]));
    
            var donviParameter = donvi != null ?
                new ObjectParameter("donvi", donvi) :
                new ObjectParameter("donvi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertCTPK", mapnParameter, soluongParameter, gianhapParameter, tenphukienParameter, maloaiParameter, anhParameter, donviParameter);
        }
    
        public virtual int insertCTPN(string mapn, Nullable<int> soluong, Nullable<double> gianhap, string tenthucung, string maloai, byte[] anh, string donvi)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var gianhapParameter = gianhap.HasValue ?
                new ObjectParameter("gianhap", gianhap) :
                new ObjectParameter("gianhap", typeof(double));
    
            var tenthucungParameter = tenthucung != null ?
                new ObjectParameter("tenthucung", tenthucung) :
                new ObjectParameter("tenthucung", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var anhParameter = anh != null ?
                new ObjectParameter("anh", anh) :
                new ObjectParameter("anh", typeof(byte[]));
    
            var donviParameter = donvi != null ?
                new ObjectParameter("donvi", donvi) :
                new ObjectParameter("donvi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertCTPN", mapnParameter, soluongParameter, gianhapParameter, tenthucungParameter, maloaiParameter, anhParameter, donviParameter);
        }
    
        public virtual int insertCTTP(string mapn, Nullable<int> soluong, Nullable<double> gianhap, string tenthucpham, string maloai, byte[] anh, string donvi)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var gianhapParameter = gianhap.HasValue ?
                new ObjectParameter("gianhap", gianhap) :
                new ObjectParameter("gianhap", typeof(double));
    
            var tenthucphamParameter = tenthucpham != null ?
                new ObjectParameter("tenthucpham", tenthucpham) :
                new ObjectParameter("tenthucpham", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var anhParameter = anh != null ?
                new ObjectParameter("anh", anh) :
                new ObjectParameter("anh", typeof(byte[]));
    
            var donviParameter = donvi != null ?
                new ObjectParameter("donvi", donvi) :
                new ObjectParameter("donvi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertCTTP", mapnParameter, soluongParameter, gianhapParameter, tenthucphamParameter, maloaiParameter, anhParameter, donviParameter);
        }
    
        public virtual int insertKH(string ten, Nullable<int> sdt, string diachi, string email)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertKH", tenParameter, sdtParameter, diachiParameter, emailParameter);
        }
    
        public virtual int insertNCC(string tenncc, string diachi, Nullable<int> sdt)
        {
            var tennccParameter = tenncc != null ?
                new ObjectParameter("tenncc", tenncc) :
                new ObjectParameter("tenncc", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNCC", tennccParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int insertnhanvien(string ten, Nullable<int> cmnd, string diachi, Nullable<int> sdt, string macv, string email)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var cmndParameter = cmnd.HasValue ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(int));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            var macvParameter = macv != null ?
                new ObjectParameter("macv", macv) :
                new ObjectParameter("macv", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertnhanvien", tenParameter, cmndParameter, diachiParameter, sdtParameter, macvParameter, emailParameter);
        }
    
        public virtual int insertnhappk(string mapn, string tenpk, Nullable<int> sl, Nullable<double> gianhap, string mancc, string dv, string maloai, byte[] anh)
        {
            var mapnParameter = mapn != null ?
                new ObjectParameter("mapn", mapn) :
                new ObjectParameter("mapn", typeof(string));
    
            var tenpkParameter = tenpk != null ?
                new ObjectParameter("tenpk", tenpk) :
                new ObjectParameter("tenpk", typeof(string));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            var gianhapParameter = gianhap.HasValue ?
                new ObjectParameter("gianhap", gianhap) :
                new ObjectParameter("gianhap", typeof(double));
    
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            var dvParameter = dv != null ?
                new ObjectParameter("dv", dv) :
                new ObjectParameter("dv", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var anhParameter = anh != null ?
                new ObjectParameter("anh", anh) :
                new ObjectParameter("anh", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertnhappk", mapnParameter, tenpkParameter, slParameter, gianhapParameter, manccParameter, dvParameter, maloaiParameter, anhParameter);
        }
    
        public virtual int insertPN(string manv, string mancc)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertPN", manvParameter, manccParameter);
        }
    
        public virtual int insertThuongPhat(string manv, Nullable<System.DateTime> ngay, string loai, Nullable<int> sotien, string lydo)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            var loaiParameter = loai != null ?
                new ObjectParameter("loai", loai) :
                new ObjectParameter("loai", typeof(string));
    
            var sotienParameter = sotien.HasValue ?
                new ObjectParameter("sotien", sotien) :
                new ObjectParameter("sotien", typeof(int));
    
            var lydoParameter = lydo != null ?
                new ObjectParameter("lydo", lydo) :
                new ObjectParameter("lydo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertThuongPhat", manvParameter, ngayParameter, loaiParameter, sotienParameter, lydoParameter);
        }
    
        public virtual int insertudhd(string tenud, Nullable<System.DateTime> ngaybd, Nullable<System.DateTime> ngaykt, Nullable<int> giamgia, string ghichu)
        {
            var tenudParameter = tenud != null ?
                new ObjectParameter("tenud", tenud) :
                new ObjectParameter("tenud", typeof(string));
    
            var ngaybdParameter = ngaybd.HasValue ?
                new ObjectParameter("ngaybd", ngaybd) :
                new ObjectParameter("ngaybd", typeof(System.DateTime));
    
            var ngayktParameter = ngaykt.HasValue ?
                new ObjectParameter("ngaykt", ngaykt) :
                new ObjectParameter("ngaykt", typeof(System.DateTime));
    
            var giamgiaParameter = giamgia.HasValue ?
                new ObjectParameter("giamgia", giamgia) :
                new ObjectParameter("giamgia", typeof(int));
    
            var ghichuParameter = ghichu != null ?
                new ObjectParameter("ghichu", ghichu) :
                new ObjectParameter("ghichu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertudhd", tenudParameter, ngaybdParameter, ngayktParameter, giamgiaParameter, ghichuParameter);
        }
    
        public virtual ObjectResult<reportHD_Result> reportHD(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reportHD_Result>("reportHD", mahdParameter);
        }
    
        public virtual ObjectResult<selectalluudai_Result> selectalluudai()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectalluudai_Result>("selectalluudai");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<tctonkho_Result> tctonkho(Nullable<int> thang, Nullable<int> nam, string mathucung)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            var mathucungParameter = mathucung != null ?
                new ObjectParameter("mathucung", mathucung) :
                new ObjectParameter("mathucung", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tctonkho_Result>("tctonkho", thangParameter, namParameter, mathucungParameter);
        }
    
        public virtual int themHD(string makh, string maud, string username)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var maudParameter = maud != null ?
                new ObjectParameter("maud", maud) :
                new ObjectParameter("maud", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themHD", makhParameter, maudParameter, usernameParameter);
        }
    
        public virtual ObjectResult<timkiemHD_Result> timkiemHD(string tk)
        {
            var tkParameter = tk != null ?
                new ObjectParameter("tk", tk) :
                new ObjectParameter("tk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timkiemHD_Result>("timkiemHD", tkParameter);
        }
    
        public virtual ObjectResult<timkiemnhanvien_Result> timkiemnhanvien(string nv)
        {
            var nvParameter = nv != null ?
                new ObjectParameter("nv", nv) :
                new ObjectParameter("nv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timkiemnhanvien_Result>("timkiemnhanvien", nvParameter);
        }
    
        public virtual ObjectResult<Tonkho_Result> Tonkho(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Tonkho_Result>("Tonkho", thangParameter, namParameter);
        }
    
        public virtual int updatecalam(string maca, string tenca, string tgbd, string tgkt)
        {
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var tencaParameter = tenca != null ?
                new ObjectParameter("tenca", tenca) :
                new ObjectParameter("tenca", typeof(string));
    
            var tgbdParameter = tgbd != null ?
                new ObjectParameter("tgbd", tgbd) :
                new ObjectParameter("tgbd", typeof(string));
    
            var tgktParameter = tgkt != null ?
                new ObjectParameter("tgkt", tgkt) :
                new ObjectParameter("tgkt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatecalam", macaParameter, tencaParameter, tgbdParameter, tgktParameter);
        }
    
        public virtual int updateHoadon(string mahd, string makh, Nullable<double> tongtien, string maud, string username)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(double));
    
            var maudParameter = maud != null ?
                new ObjectParameter("maud", maud) :
                new ObjectParameter("maud", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateHoadon", mahdParameter, makhParameter, tongtienParameter, maudParameter, usernameParameter);
        }
    
        public virtual ObjectResult<uudaimoinhat_Result> uudaimoinhat(string maUD)
        {
            var maUDParameter = maUD != null ?
                new ObjectParameter("MaUD", maUD) :
                new ObjectParameter("MaUD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uudaimoinhat_Result>("uudaimoinhat", maUDParameter);
        }
    }
}
