using HotCat.Model.Enums;
using HotCat.Model.Interfaces;

namespace HotCat.Model.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        //baseentity geneli kapsadığı için soyut olacak (abstract)

        //open close prensibini getirdik. değiştiremeyiz ama geliştirebiliriz.
        //single responsibility prensibi de var. sınıflarımızın tek bir sorumluluğu olması için.

        public BaseEntity()
        {
            Status = DataStatus.INSERTED;

            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName; //sistemde oturum açmış olan kullanıcının bilgisayarın adını verir
            CreatedIpAddress = "192.168.1.1"; //todo: ttnetin verdiği custom id düzenle bunu 
            MasterId = Guid.NewGuid();
            IsActive = true;

        }
        public int ID { get; set; }
        public Guid MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
