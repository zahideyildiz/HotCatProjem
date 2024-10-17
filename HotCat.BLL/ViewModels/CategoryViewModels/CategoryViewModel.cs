using HotCat.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotCat.BLL.ViewModels.CategoryViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Kategori Ad")]
        public string CategoryName { get; set; }
        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Display(Name ="Aktif")]
        public bool IsActive { get; set; }

        [Display(Name ="Durum")]
        public DataStatus Status { get; set; }
    }
}
