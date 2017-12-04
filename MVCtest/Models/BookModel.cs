using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static MVCtest.Help.Validation;

namespace MVCtest.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入书籍名称")]
        [StringLength(maximumLength:10,ErrorMessage ="最长10")]
        [BookNameValidation]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}