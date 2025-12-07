using Microsoft.AspNetCore.Antiforgery;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeThiMauLTW.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }

    [Required(ErrorMessage = "Ten hang khong duoc bo trong")]
    public string TenHang { get; set; }

    [Required(ErrorMessage = "Gia khong duoc bo trong")]
    [Range(100, 5000, ErrorMessage = "Gia phai nam trong khoang tu 100 den 5000")]
    public decimal? Gia { get; set; }

    [Required(ErrorMessage = "Anh khong duoc bo trong")]
    [RegularExpression(@"^.*\.(jpg|png|gif|tiff)$",
    ErrorMessage = "File ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang? MaLoaiNavigation { get; set; }
}