using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Killar.Models
{
    public class Users
    {

        public static int ADMIN = 0;

        public static int PADRAO = 1;

        public int Id { get; set; } // Primary Key for convention

        [StringLength(60)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [StringLength(40)]
        public string LoginWr { get; set; }

        [StringLength(40)]
        public string LoginName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string CheckedPassword { get; set; }

        [StringLength(40)]
        public string Lane { get; set; }

        [StringLength(40)]
        public string Elo { get; set; }

        public int Tipo { get; set; }

        public ICollection<Posts> PostsList { get; set; } // Coleção de Post dos usuários

        public ICollection<Comments> CommentsList { get; set; } // Coleção de Comentários dos usuários

    }
}