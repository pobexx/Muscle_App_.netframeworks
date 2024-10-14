using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Muscle_App_.NetFrameworks.Models
{
    [Table("user", Schema = "public")]
    public class User: AbstractEntity
    {
        [Description("自動連番のId")]
        [Column("Id"),Key] public int Id { get; set; }

        [Description("ユーザ名")]
        [Column("name"),        Required] public string Name {  get; set; }

        [Description("表示されるユーザ名")]
        [Column("username"),     Required] public string Username { get; set; }

        [Description("ログインId")]
        [Column("loginId"),EmailAddress,Required] public string EmailAddress { get; set; }
         
        [Description("パスワード")]        
        [Column("password"),DataType(DataType.Password),Required] public string Password { get; set; }


    }
    
}