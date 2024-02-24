using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteOne.Entities{
    public class UserCategory{
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }



        
        


    }
}