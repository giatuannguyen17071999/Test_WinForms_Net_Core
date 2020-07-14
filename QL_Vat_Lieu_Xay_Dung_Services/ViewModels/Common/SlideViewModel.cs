using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;

namespace QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common
{
    public class SlideViewModel
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Description { set; get; }

        [StringLength(250)]
        [Required]
        public string Image { set; get; }

        [StringLength(250)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public Status Status { get; set; }


        public string Content { set; get; }
        // cái này dùng để group nhiều slide lại để select
        [StringLength(25)]
        [Required]
        public string GroupAlias { get; set; }
    }
}
