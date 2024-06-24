﻿using ASPFastApi.Models.Entities;

namespace ASPFastApi.Models.ArticlesDao
{
    public class AddArticleDao
    {
        public string ArticleName { get; set; } = null!;
        public string? ArticleDescription { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public bool Visibility { get; set; }
    }
}
