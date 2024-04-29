using System.Collections.ObjectModel;

namespace APIFinantial.Models;

public class UserData
{
    public int UserDataId { get; set; }
    public ICollection<Account> Accounts { get; set; }

    public UserData()
    {
        Accounts = new Collection<Account>();
    }
}
