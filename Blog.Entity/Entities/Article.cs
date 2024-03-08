using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Article
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }

        public Guid CategoryId {get; set;}
        public Category Category {get; set;}
        public Guid ImageId {get; set;}
        public Image Image {get; set;}
        
    }
}