using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }
        //---------------------------------------
        [Display(Name = "کد گروه")]
        [Required(ErrorMessage = "لطفا کد گروه را وارد کنید")]
        public int GroupID { get; set; }
        //---------------------------------------
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید")]
        [MaxLength(100)]
        public string Title { get; set; }
        //---------------------------------------
        [Display(Name = "توضیح کوتاه")]
        [Required(ErrorMessage = "لطفا یک توضیح کوتاه برای نمایش تایپ کنید")]
        [MaxLength(350)]
        public string ShortDescription { get; set; }
        //---------------------------------------
        [Display(Name = "متن خبر")]
        [Required(ErrorMessage = "لطفا متن خبر را تایپ کنید")]
        public string Text { get; set; }
        //---------------------------------------
        [Display(Name = "دفعات بازدید")]
        public int Visit { get; set; }
        //---------------------------------------
        [Display(Name = "عکس از خبر")]
        public string ImageName { get; set; }
        //---------------------------------------
        [Display(Name = "تمایش در اسلایدر")]
        public bool ShowInSlider { get; set; }
        //---------------------------------------
        [Display(Name = "تاریخ")]
        public DateTime CraeteDate { get; set; }
        //-----------Navigation Property---------
        public virtual PageGroup PageGroup { get; set; }
        public virtual List<PageComment> PageComments { get; set; }

        public Page()
        {
            
        }
    }
}
