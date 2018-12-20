using System;
using System.ComponentModel.DataAnnotations;

namespace HAC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Crendtials { get; set; }
        public string Password { get; set; }
    }
}