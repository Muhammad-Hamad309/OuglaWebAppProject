﻿using System.ComponentModel.DataAnnotations;

namespace OuglaWebApp.Models
{
    public class BlogModel
    {
        [Required(ErrorMessage = "Please Enter a title")]
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
    }

}
