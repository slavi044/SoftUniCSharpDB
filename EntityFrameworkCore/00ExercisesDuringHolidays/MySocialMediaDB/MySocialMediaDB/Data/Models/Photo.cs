﻿namespace MySocialMediaDB.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Photo
    {
        public Photo()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public byte[] Picture { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string PageId { get; set; }
        public Page Page { get; set; }
    }
}