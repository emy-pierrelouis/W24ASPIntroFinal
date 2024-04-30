using System;
using System.Collections.Generic;

namespace W24ExamFinal.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
