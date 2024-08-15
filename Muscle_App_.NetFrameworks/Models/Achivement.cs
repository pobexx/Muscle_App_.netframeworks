using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Muscle_App_.NetFrameworks.Models
{
    [Table("achivement",Schema = "public")]
    public class Achivement: AbstractEntity
    {
        [Column("id"),Key] public int Id { get; set; }

        [Column("user_id"), Required] public int UserId { get; set; }

        [Column("menu_id"),Required]public int MenuId {  get; set; }

        [Column("assist"),Required]public bool Assist {  get; set; }

        [Column("times")]public int Times { get; set; }

        [Column("weight")]public float Weight {  get; set; }

        [Column("memo")]public string Memo { get; set; }

      
    }
}