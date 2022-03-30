using Microsoft.AspNetCore.Http;
using System;

namespace Homeworkfour.Models
{
    public class TesterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public IFormFile Image { get; set; }
    }
}
