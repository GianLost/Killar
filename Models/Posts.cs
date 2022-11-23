using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Killar.Models
{
    public class Posts
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string Author { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public ICollection<Comments> Comment { get; set; }

        public int UsersId { get; set; } // foreign key for convention

        public Users User { get; set; }

    }
}