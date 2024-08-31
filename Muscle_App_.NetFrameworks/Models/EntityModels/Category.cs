using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Muscle_App_.NetFrameworks.Models
{
    [Table("category", Schema = "public")]
    public class Category: AbstractEntity
    {
       [Column("Id"),Key] public int Id { get; set; }

        [Column("User_Id"),Required]public int UserId { get; set; }

        [Column("parts"),Required]public string Parts { get; set; }

    }
}