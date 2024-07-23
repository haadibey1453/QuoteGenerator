using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteGeneratorThree.Models
{
    public class ProductQuote
    {
        public int ProductId { get; set; }
        public int QuoteId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
        [ForeignKey(nameof(QuoteId))]
        public Quote Quote { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
