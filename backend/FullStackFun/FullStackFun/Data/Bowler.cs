using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Erickson.Data
{
    [Table("Bowlers")] // Explicitly map to the Bowlers table
    public class Bowler
    {
        [Key]
        [Column("BowlerID")] // Matches database column name
        public int BowlerId { get; set; }

        [Required]
        [Column("BowlerFirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Column("BowlerMiddleInit")]
        public string? MiddleInit { get; set; } // Nullable since middle name may be missing

        [Required]
        [Column("BowlerLastName")]
        public string LastName { get; set; } = string.Empty;

        [Column("BowlerAddress")]
        public string? Address { get; set; } // Making nullable in case some bowlers don’t have addresses

        [Column("BowlerCity")]
        public string? City { get; set; }

        [Column("BowlerState")]
        public string? State { get; set; }

        [Column("BowlerZip")]
        public string? Zip { get; set; }

        [Column("BowlerPhoneNumber")]
        public string? PhoneNumber { get; set; }

        [Column("TeamID")] // Links to the Teams table
        public int TeamID { get; set; }
    }
}
