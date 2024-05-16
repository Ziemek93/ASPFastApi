using Microsoft.EntityFrameworkCore;
using Faker;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.Design;
using ASPFastApi.Models.Entities;

namespace FastApi.Context
{
    public static class DataSeed
    {
        //ModelBuilder modelBuilder;
        //public DataSeed(ModelBuilder modelBuilder) { 
        //    this.modelBuilder = modelBuilder;
        //}
        
        //public void ManyToManyShuffle()
        //{

        //}

        public static void generateData(ModelBuilder modelBuilder)
        {
            Random random = new Random();

            //modelBuilder.Entity<Article>().HasMany()

            var tags = Enumerable.Range(1, 20).Select(i => new Tag
            {
                TagId = i,
                Title = StringFaker.SelectFrom(random.Next(5, 20), "Test Word bla bla")
            });
            

            //Category[] categories = new Category[100];
            //var categories = Enumerable.Range(1, 10).Select(i => new Category
            //{
            //    CategoryId = i,
            //    CategoryName = TextFaker.Sentence(),
            //    CategoryDescription = TextFaker.Sentences(3),
            //    Articles = Enumerable.Range(1, 5).Select(pi => new Article
            //    {
            //        ArticleId = pi,
            //        ArticleName = TextFaker.Sentence(),
            //        ArticleDescription = TextFaker.Sentences(3),
            //        Visibility = true,
            //        CategoryId = i,
            //        Tags = tags.ToList()
            //    }).ToList()
            //});

            // Seed Categories without Articles
            //modelBuilder.Entity<Article>().HasKey(c => c.ArticleId);
            //modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            //modelBuilder.Entity<Article>().Property(e => e.ArticleId).UseIdentityColumn();
            //modelBuilder.Entity<Category>().Property(e => e.CategoryId).UseIdentityColumn();
            var categories = Enumerable.Range(1, 10).Select(i => {
                string desc = TextFaker.Sentences(random.Next(1, 3));
                desc = desc.Length > 200 ? desc.Substring(0, 200) : desc;
                return new Category()
                {
                    CategoryId = i,
                    CategoryName = Faker.StringFaker.SelectFrom(random.Next(5, 50), TextFaker.Sentence()),
                    CategoryDescription = desc
                };
            }).ToList();
            


            int counter = 1;
            // Seed Articles with foreign key references to Categories
            var articles = categories.SelectMany(c => Enumerable.Range(counter, 5).Select(i =>
            {
                string name = StringFaker.SelectFrom(random.Next(5, 50), TextFaker.Sentence());
                name = name.Length > 30 ? name.Substring(0, 30) : name;
                counter++;
                return new Article
                {
                    ArticleId = i,
                    ArticleName = name,
                    ArticleDescription = TextFaker.Sentences(random.Next(1,3)),
                    Visibility = true,
                    CategoryId = c.CategoryId,  // Set foreign key to existing Category
                    //Tags = tags.ToList()  // Assuming tags is correctly initialized
                };
            })).ToList();


            var comments = Enumerable.Range(1, 10).Select(i =>{
                string cont = StringFaker.SelectFrom(random.Next(20, 161), TextFaker.Sentence());
                cont = cont.Length > 200 ? cont.Substring(0, 200) : cont;

                return new Comment
                {
                    CommentId = i,
                    ArticleId = random.Next(1, articles.Count() + 1),
                    Content = cont
                };
            });




            var comment = modelBuilder.Entity<Comment>();
            var article = modelBuilder.Entity<Article>();
            var category = modelBuilder.Entity<Category>();
            var tag = modelBuilder.Entity<Tag>();


            tag.HasData(tags);
            comment.HasData(comments);
            category.HasData(categories);
            article.HasData(articles);


            //Many to many relationship
            modelBuilder.Entity<Article>().HasMany(a => a.Tags).WithMany(t => t.Articles)
                 .UsingEntity(j => j.ToTable("ArticleTag").HasData(
                    Enumerable.Range(1, 50).Select(
                        _ => new
                        {
                            TagId = random.Next(1, tags.Count()+1),
                            ArticleId = random.Next(1, articles.Count()+1)

                        }).Distinct()
                     ));




            //modelBuilder.Entity("ArticleTag")               
            //    .HasData(
                    //Enumerable.Range(1, 50).Select(
                    //    _ => new
                    //    {
                    //        TagId = random.Next(1, tags.Count()),
                    //        ArticleId = random.Next(1, articles.Count())

                    //    }
            //        )
            //    );



        }
    }
}
