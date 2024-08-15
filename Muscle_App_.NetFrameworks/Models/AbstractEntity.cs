using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muscle_App_.NetFrameworks.Models
{
    public class AbstractEntity
    {
        [Description("削除フラグ")]
        [Column("deleted"), Required] public bool Deleted { get; set; }
        [Column("created_datetime"), Required] public DateTime CreatedDatetime { get; set; }

        [Column("updated_datetime")] public DateTime UpdatedDatetime { get; set; }

        [Column("deleted_datetime")] public DateTime DeletedDatetime { get; set; }
    }
}