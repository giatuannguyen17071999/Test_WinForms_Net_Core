using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Data.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.SharedKernel;

namespace QL_Vat_Lieu_Xay_Dung_Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>, ISwitchable
    {
        public Slide()
        {

        }

        public Slide(int id,string name,string description,string image,string url,int? displayOrder, Status status,string content, string groupAlias)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Url = url;
            DisplayOrder = displayOrder;
            Status = status;
            Content = content;
            GroupAlias = groupAlias;
        }
        public Slide(string name, string description, string image, string url, int? displayOrder, Status status, string content, string groupAlias)
        {
            Name = name;
            Description = description;
            Image = image;
            Url = url;
            DisplayOrder = displayOrder;
            Status = status;
            Content = content;
            GroupAlias = groupAlias;
        }
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
