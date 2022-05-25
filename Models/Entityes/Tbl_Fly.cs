using System.ComponentModel.DataAnnotations;

public class Tbl_Fly
{
    [Key]
    public int Id { get; set; }
    public string Name_Company { get; set; }
    public string Mabda { get; set; }
    public string Maghsad { get; set; }
    public DateTime Parvaz { get; set; }
    public int Mablagh { get; set; }
    public int Tedad { get; set; }

}