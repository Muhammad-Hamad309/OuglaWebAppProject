﻿using System.ComponentModel.DataAnnotations;

namespace OuglaWebApp.Models
{
    public class Content
    {
        public string sitename { get; set; }
        public string about { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string LinkedInLink { get; set; }
        public string ThemeColorCode { get; set; }    
        public byte[] logoImg { get; set; }
        public byte[] BannerImg { get; set; }   
        public byte[] ObjectImg { get; set; }
    }
}
