using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ASPFastApi.Models.Entities;

public class User : IdentityUser
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

    public virtual IEnumerable<Article> Articles { get; set; }
    public virtual IEnumerable<Comment> Comments { get; set; }

}