using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinantial.Models;

[Table("UserDatas")]
public class UserData
{
    [Key]
    public int UserDataId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public ICollection<Account> Accounts { get; set; }

    public UserData()
    {
        Accounts = new Collection<Account>();
    }
}
