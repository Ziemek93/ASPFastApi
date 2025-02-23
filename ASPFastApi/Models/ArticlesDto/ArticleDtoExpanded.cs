﻿using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Models.ArticlesDto
{
    public class ArticleDtoExpanded
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; } = null!;
        public string? ArticleDescription { get; set; }
        public Category Category { get; set; }
        public bool Visibility { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
    internal sealed class Validator : Validator<ArticleDtoExpanded>
    {
        public Validator()
        {

        }
    }
}
