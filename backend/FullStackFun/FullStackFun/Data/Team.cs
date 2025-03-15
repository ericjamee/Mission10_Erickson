using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Erickson.Data
{
    [Table("Teams")] // Explicitly map to the Teams table in SQLite
    public class Team
    {
        [Key]
        [Column("TeamID")]
        public int TeamID { get; set; }

        [Required]
        [Column("TeamName")]
        public string TeamName { get; set; } = string.Empty;
    }
}
