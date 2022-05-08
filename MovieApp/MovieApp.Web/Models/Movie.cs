using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage ="film başlığı eklemelisiniz.")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="film başlığı 5-10 karakter aralığında olmalıdır.")]
        public string Title { get; set; }  // null
        [Required(ErrorMessage ="film açıklaması eklemelisiniz.")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required]
        public string ImageUrl { get; set; } // null
        [Required]
        public int? GenreId { get; set; } // null
    }
}
