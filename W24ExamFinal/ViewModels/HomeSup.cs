using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using W24ExamFinal.Models;

namespace W24ExamFinal.ViewModels
{
    internal class HomeSup
    {
        [Key, Column(Order = 0)]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public List<Product> Top3 { get; set; }
    }
}