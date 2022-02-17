using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class PageComment
    {
        [Key]
        public int CommentID { get; set; }
        //---------------------------------------
        [Display(Name = "کد خبر")]
        [Required(ErrorMessage = "لطفا کد خبر را وارد کنید")]
        public int PageID { get; set; }
        //---------------------------------------
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام کامل خود را وارد کنید")]
        [MaxLength(30)]
        public string Name { get; set; }
        //---------------------------------------
        [Display(Name = "ایمیل")]
        [MaxLength(100)]
        public string Email { get; set; }
        //---------------------------------------
        [Display(Name = "وب سایت")]
        [MaxLength(100)]
        public string WebSite { get; set; }
        //---------------------------------------
        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "لطفا نظر خودرا وارد کنید")]
        [MaxLength()]
        public string Comment { get; set; }
        //---------------------------------------
        [Display(Name = "تاریخ ثبت نظر")]
        public DateTime CreateDate { get; set; }
        //-----------Navigation Property---------
        public virtual Page Page { get; set; }

        public PageComment()
        {
            
        }
    }
}
