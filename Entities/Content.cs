using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteOne.Entities{
    public class Content{
        public int Id { get; set; }
        [Required]
        [StringLength(200,MinimumLength =2)]
        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        [Required]
        public CategoryItem CategoryItem { get; set; }


    }
}