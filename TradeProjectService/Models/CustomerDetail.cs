using System.ComponentModel.DataAnnotations;

namespace TradeProjectService.Models
{
    public class CustomerDetail
    {
        [Key]
        public int Id { get; set; }
        public string customerName { get; set; }
        public string Email { get; set; }
    }

}
