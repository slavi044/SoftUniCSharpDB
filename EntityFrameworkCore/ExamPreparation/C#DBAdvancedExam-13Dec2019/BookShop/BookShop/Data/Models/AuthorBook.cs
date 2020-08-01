﻿namespace BookShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class AuthorBook
    {

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}