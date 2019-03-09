using System;
using Microsoft.AspNetCore.Http;

namespace testapp.Models
{
    public class OtherInputModel
    {
        public string Text { get; set; }
		
        public string Body { get; set; }
		
        public IFormFile Image { get; set; }
    }
}