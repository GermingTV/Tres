using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("USER")]
public class User
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID")]
    public int Id { get; set; }
    [Required, StringLength(20)]
    [Column("USERNAME")]
    public string Name { get; set; }
    [Required]
    [Column("EMAIL")]
    public string Email { get; set; }
    [Required, StringLength(32,MinimumLength = 8), DataType(DataType.Password)]
    [Column("PASSWORD")]
    public string Password { get; set; }
    [Required]
    [Column("STATS_ID")]
    public int StatsId { get; set; }
    public Stats Stats { get; set; }
    
   
}