using System;
using Microsoft.AspNetCore.Http;

namespace testapp.Models
{
    public class InputModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
    }
}