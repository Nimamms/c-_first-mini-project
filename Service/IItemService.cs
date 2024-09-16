
using DotNetHW2;

namespace Service;

public interface IItemService
{

    public void sign_up(string name, string email, string password, int cash);
    public void sign_in(string name, string password);



}