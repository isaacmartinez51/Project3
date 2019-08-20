using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Continental.CUP.Repositories.Data.Entities
{
    [Table("OrderDetail")]
    public class OrderDetailEModel
    {
        [Key]
        public int OrderDetailID { get; set; }

        [Display(Name = "")]
        public int OrderID { get; set; }

        public int Traza { get; set; }

        [Display(Name = "")]
        public int UnitID { get; set; }

        public string PartNumber { get; set; }

        public int Quantity { get; set; }
    }
}
