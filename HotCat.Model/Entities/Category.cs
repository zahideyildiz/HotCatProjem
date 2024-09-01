using HotCat.Model.Base;

namespace HotCat.Model.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        // Mapping
        //Bir kategorinin n tane ürünü olabilir.
        public virtual List<Product> Products { get; set; }

    }
}
