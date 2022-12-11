using System.ComponentModel.DataAnnotations.Schema;
using BlazorServerApp.Pages;

namespace BlazorServerApp.Data.Models;

public class Order
{
    public Order()
    {
        CreatedAt = DateTime.Now;
    }
    public int Id { get; set; }
    public DateTime CreatedAt{ get; set; }
    public int Quantity{ get; set; }
    [ForeignKey("CustomerId")]
    public int CustomerId{ get; set; }
    public virtual Customer Customer{ get; set; }
    [ForeignKey("ItemId")]
    public int ItemId{ get; set; }
    public virtual Item Item{ get; set; }

}