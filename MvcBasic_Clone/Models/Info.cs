using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage ="需要輸入姓名")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最少需要3個字元")]
        public string Name { get; set; }
        [Required(ErrorMessage = "需要輸入電話")]
        //[RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "要為09XX-XXX-XXX")]
        [Display(Name = "電話")]
        public int Phone { get; set; }
        [Required(ErrorMessage ="需要輸入信箱")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "信箱")]
        public string Email { get; set; }

        [Display(Name = "性別")]
        public bool Gender { get; set; }
    }
}