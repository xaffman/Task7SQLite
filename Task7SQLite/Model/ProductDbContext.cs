using Microsoft.EntityFrameworkCore;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    private Product[] GetProducts() => new Product[] {
        new Product{
             ProductID = 4,
             ProductName = "Биг ДНР",
             ProductDescription = "Вкуснейший бургер с двумя сочными котлетами, свежими овощами и мягкими булочками.",
             ProductPrice = 250,
             ProductUnit = 378
             },


    new Product{
             ProductID = 5,
             ProductName = "ЛНР Спешиал",
             ProductDescription = "Элитный бургер с котлетой из мраморной говядины, с сыром Маасдам, набором свежих овощей и фирменным соусом.",
             ProductPrice = 350,
             ProductUnit = 246
             },

    new Product{
             ProductID = 6,
             ProductName = "Сало",
             ProductDescription = "Нежнейшее сало с самых вкусных хрюшек Донбасса.",
             ProductPrice = 180,
             ProductUnit = 432
        },

    new Product{
             ProductID = 7,
             ProductName = "Добрая кола",
             ProductDescription = "Вкусный, сладкий и освежающий напиток.",
             ProductPrice = 100,
             ProductUnit = 378
         },

    new Product{
             ProductID = 8,
             ProductName = "Картофель фри",
             ProductDescription = "Жареные в масле палочки белорусского картофеля.",
             ProductPrice = 80,
             ProductUnit = 653
         },

    new Product{
             ProductID = 9,
             ProductName = "Соус Крымский",
             ProductDescription = "Майонейзный соус с набором трав и специй со всего полуострова.",
             ProductPrice = 40,
             ProductUnit = 736
         }
    };
}