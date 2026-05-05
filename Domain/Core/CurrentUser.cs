using Model.Entities;

namespace Domain.Core;

public class CurrentUser : User
{
    private static CurrentUser _instance = new CurrentUser();
    //HIER STATS EINFÜGEN
    private CurrentUser(){}
    public static CurrentUser getInstance() => _instance;
}