using System;
namespace MyWebsite.Models
{
	public class Blog
	{
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
		public Blog()
		{
		}
	}
}

