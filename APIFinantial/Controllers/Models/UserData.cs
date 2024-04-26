namespace APIFinantial.Controllers.Models;

public class UserData 
{
    public int UserDataId { get; set; }
    public List<Account>? Accounts { get; set; }
}
