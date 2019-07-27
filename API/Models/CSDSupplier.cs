using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CSDSupplier
    {
        [Key] 
        public int SupplierID { get; set; }
        public string SupplierNumber { get; set; }

    }
}