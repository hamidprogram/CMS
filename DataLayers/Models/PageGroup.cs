using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class PageGroup
    {
        [Key]
        public int GroupID { get; set; }
        //---------------------------------------
        [Display(Name = "نام گروه")]
        [Required(ErrorMessage = "")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        //-----------Navigation Property---------

        public virtual List<Page> Pages { get; set; }

        public PageGroup()
        {

        }
    }
}
