using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCtest.Models
{
    public class UserLogin
    {
        [StringLength(maximumLength:7,ErrorMessage ="TOO LONG")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}