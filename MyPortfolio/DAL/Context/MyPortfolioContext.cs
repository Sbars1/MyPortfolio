﻿using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
using System.Security.Cryptography.X509Certificates;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GRL0GHL\\SQLEXPRESS ; initial Catalog=MyPortfolioDb;integrated Security =true;");
        }
            public DbSet<About> Abouts { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Exprience> Expriences { get; set; }
            public DbSet<Feature> Features { get; set; }
            public DbSet<Message> Messages { get; set; }
            public DbSet<Portfolio> Portfolios { get; set; }
            public DbSet<Skill> Skills{ get; set; }
            public DbSet<SocialMedia> SocialMedias { get; set; }
            public DbSet<Testimonial> Testimonials { get; set; }
            public DbSet<ToDoList> ToDoLists { get; set; }
    }
    }

