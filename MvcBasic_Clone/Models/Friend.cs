using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Friend
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "名字")]

        public string Name { get; set; }
        [Display(Name = "電話")]

        public string Phone { get; set; }
        [Display(Name = "信箱")]

        public string Email { get; set; }
        [Display(Name = "城市")]

        public string City { get; set; }
    }
}