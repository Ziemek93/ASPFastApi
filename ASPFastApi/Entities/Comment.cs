using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastApi.Entity;

public class Comment
{
    [Key]
    public int CommentId { get; set; }
    [Required]

    [StringLength(200)]
    public string Content { get; set; }
    public int? ArticleId { get; set; }

    //[ForeignKey("UserId")]
    //public virtual User? User { get; set; }

    [ForeignKey("ArticleId")]
    [InverseProperty("Comments")]
    public virtual Article Article { get; set; }
}
