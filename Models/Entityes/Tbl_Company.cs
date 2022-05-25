using System.ComponentModel.DataAnnotations;

public class Tbl_Company
{   
    [Key]
    public int Id { get; set; }
    public string Name_Company { get; set; }
    public DateTime Tarikh_Tasis { get; set; }
}