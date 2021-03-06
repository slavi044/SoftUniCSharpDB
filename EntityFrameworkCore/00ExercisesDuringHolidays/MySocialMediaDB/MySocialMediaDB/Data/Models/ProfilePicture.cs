﻿namespace MySocialMediaDB.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProfilePicture
    {
        public ProfilePicture()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public byte[] Picture { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
//-Id(Required)
//-Picture byte[]
//-CreatedOn DateTime
//-User User(Required)