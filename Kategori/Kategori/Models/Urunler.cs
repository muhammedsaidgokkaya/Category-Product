using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.Models
{
    public class Urunler
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImgName { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
        [Required(ErrorMessage ="Kategori gir")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
