using System.ComponentModel.DataAnnotations;

namespace QuoteGeneratorThree.Models
{
    public class Quote
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public decimal NetTotal { get; set; }
        //public ICollection<Product> Products { get; set; } = [];
        public List<ProductQuote> ProductQuotes { get; set; } = [];
    }
}
