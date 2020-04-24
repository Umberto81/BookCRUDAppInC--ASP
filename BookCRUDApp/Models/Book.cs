using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCRUDApp.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Author { get; set; }

        public string Name { get; set; }

        public int ISBN { get; set; }
    }
}
