using Microsoft.EntityFrameworkCore;

public class Context :DbContext
{
  public DbSet<Tbl_Company>tbl_Companies { get; set; }
  public DbSet<Tbl_Fly>tbl_Flies { get; set; }


          protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source =. ; initial Catalog = Ticket; integrated Security = true ;");
        }
  
}