using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class StockItem
    {
        [Key] public int StockID { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Unit { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal LastCost { get; set; }
        public decimal AveCost { get; set; }
        public decimal QtyOnHand { get; set; }
        public int StockCategoryID { get; set; }
        public int VATCategoryID { get; set; }
    }
}