using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.User;

namespace QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product
{
    public class BillViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMobile { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }
        public Guid? CustomerId { set; get; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        //public AppUserViewModel User { get; set; }
        public List<BillDetailViewModel> BillDetails { set; get; }
    }
}
