using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Muscle_App_.NetFrameworks.Models
{
    [Table("menu",Schema = "public")]
    public class Menu: AbstractEntity
    {
        [Column("id"),Key]public int Id { get; set; }

        [Column("user_id"),Required]public int UserId { get; set; }

        [Column("category_id"),Required]public int CategoryId { get; set; }

        [Column("item"),Required]public string Item { get; set; } 
    }
}