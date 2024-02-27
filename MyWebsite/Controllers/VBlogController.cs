// Controllers/VBlogController.cs
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using System;
using System.Collections.Generic;

public class VBlogController : Controller
{
    public IActionResult Index()
    {
        var blogs = new List<Blog>
        {
            new Blog
            {
                Title = "Blog Başlık 1",
                Content = "Blog İçeriği 1",
                DateCreated = DateTime.Now
            },
            new Blog
            {
                Title = "Blog Başlık 2",
                Content = "Blog İçeriği 2",
                DateCreated = DateTime.Now
            }
        };

        return View(blogs);
    }

    public IActionResult Details(string title)
    {
        var blog = new Blog
        {
            Title = title,
            Content = "Blog İçeriği", // Gerçek içeriği buradan almanız gerekecek
            DateCreated = DateTime.Now
        };

        return View(blog);
    }
}




