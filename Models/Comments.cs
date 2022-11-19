using System;

namespace Killar.Models
{
    public class Comments
    {
        public int Id { get;set; }
        public string Author { get;set; }
        public string Content { get;set; }
        public DateTime CommentDate { get;set; }
        public int PostsId { get;set; } // foreign key for convention
        public int UsersId { get;set; } // foreign key for convention
        public Users User { get;set; }
        public Posts Post { get;set; }
    }
}