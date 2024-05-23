using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPFastApi.Models.Entities;

public class Tag
{
    public Tag()
    {
        Articles = new HashSet<Article>();
    }
    [Key]
    public int TagId { get; set; }
    [Required]
    [StringLength(50)]
    public string Title { get; set; }

    [ForeignKey("TagId")]
    [InverseProperty("Tags")]
    public virtual ICollection<Article>? Articles { get; set; }

}

