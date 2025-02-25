﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ASPFastApi.Models.Entities;

public class Article
{
    public Article()
    {
        Comments = new HashSet<Comment>();
        Tags = new HashSet<Tag>();
    }

    [Key]
    public int ArticleId { get; set; }
    public int CategoryId { get; set; }
    public int? UserId { get; set; }

    [StringLength(30)]
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }

    //[ForeignKey("UserId")]
    //[InverseProperty("Articles")]
    //public virtual User? User { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Articles")]
    [XmlIgnore]
    [JsonIgnore]
    public virtual Category Category { get; set; }
    [InverseProperty("Article")]
    [XmlIgnore]
    [JsonIgnore]
    public virtual ICollection<Comment> Comments { get; set; }
    [ForeignKey("ArticleId")]
    [InverseProperty("Articles")]
    [XmlIgnore]
    [JsonIgnore]
    public virtual ICollection<Tag> Tags { get; set; }
}
