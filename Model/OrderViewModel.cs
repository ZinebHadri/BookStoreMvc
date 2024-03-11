
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderViewModel
{
    public int UserId { get; set; }
    public List<int> BookIds { get; set; }
    // Ajoutez d'autres propriétés selon les besoins
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public List<OrderItemViewModel> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
}


