using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("STATS")]
public class Stats
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("STATS_ID")]
    public int Id { get; set; }
    [Column("CARDS_PULLED")]
    public int CardsPulled { get; set; }
}