using HotCat.Model.Base;

namespace HotCat.Model.Entities
{
    public class Table : BaseEntity
    {
        public string TableNumber { get; set; }

        public string TableName { get; set; }

        public List<Order> Orders { get; set; }





    }
}
