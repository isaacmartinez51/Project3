using System.ComponentModel.DataAnnotations;

namespace Continental.CUP.Repositories.ViewModels
{

    public class OrderDetailVModel
    {
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
