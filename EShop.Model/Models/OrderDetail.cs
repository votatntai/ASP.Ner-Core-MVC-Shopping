using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Model.Models
{
    [Table("OrderDetails")]
    internal class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int? Quantity { get; set; }
    }
}