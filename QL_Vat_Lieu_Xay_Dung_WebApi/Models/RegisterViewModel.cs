using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_WebApi.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Yêu Cầu Nhập Tài Khoản", AllowEmptyStrings = false)]
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Yêu Cầu Nhập Họ Và Tên", AllowEmptyStrings = false)]
        [Display(Name = "Họ Và tên")]
        public string FullName { set; get; }

        [Display(Name = "Ngày Sinh")]
        public DateTime? BirthDay { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật Khẩu Phải Từ 6 Ký Tự Trở Lên.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác Nhận Mật Khẩu")]
        [Compare("Password", ErrorMessage = "Xác Nhận Mật Khẩu Không Trùng Khớp Với Mật Khẩu.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }

        [Display(Name = "Điện Thoại")]
        public string PhoneNumber { set; get; }

        [Display(Name = "Hình Đại Diện")]
        public string Avatar { get; set; }
    }
}
