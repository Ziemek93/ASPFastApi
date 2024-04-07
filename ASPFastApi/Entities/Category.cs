using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastApi.Entity;

public class Category
{
    public Category() {
        Articles = new HashSet<Article>();
    }

    [Key]
    public int CategoryId { get; set; }
    [Required]
    [StringLength(50)]
    public string CategoryName { get; set; }
    [Required]
    [StringLength(200)]
    public string CategoryDescription { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Article> Articles { get; set; }
}
