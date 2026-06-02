using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class ForgottenUser
{

    [EmailAddress]
    public string Email { get; set; }
    
}