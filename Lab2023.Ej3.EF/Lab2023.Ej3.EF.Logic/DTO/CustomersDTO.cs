using System.ComponentModel.DataAnnotations;

namespace Lab2023.Ej3.EF.Logic.DTO
{
    public class CustomersDTO
    {
        [Key]
        [StringLength(5)]
        public string CustomerID { get; set; }
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(30)]
        public string ContactName { get; set; }
        [StringLength(15)]
        public string City { get; set; }
    }
}
