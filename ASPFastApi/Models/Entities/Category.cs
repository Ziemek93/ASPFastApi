﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPFastApi.Models.Entities;

public class Category
{
    public Category()
    {
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
    public int UserId { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Article> Articles { get; set; }
}
