namespace BlazorServerApp.Data.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sku { get; set; }
    public float Price { get; set; }
    public string Category { get; set; }
}