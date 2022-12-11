using BlazorServerApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace BlazorServerApp.Data;

public class DataContext:DbContext
{
    private static DataContext instance = null;

    public static DataContext GetInstance()
    {
        if (instance == null)
            instance = new DataContext();
        return instance;
    }
    public DbSet<Item> Items { get; set; }

    private DataContext()
    {
        Database.EnsureCreated();

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connString = "server=localhost;port=3306;database=entity;user=root;password=root";
        optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(new MySqlConnection(connString)));
    }
}