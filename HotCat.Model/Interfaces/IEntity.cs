using HotCat.Model.Enums;

namespace HotCat.Model.Interfaces
{
    //Bu interface bütün entitylere içerisinde barındırdığı özellikleri (propertyleri) miras yöntemiyle teslim edecek. Aynı zamanda bu interface dışarıdan bir <T> alacak. Almış olduğu bu generic tip'e göre ID'nin tipini belirleyecek. ID'nin tipi istediğimiz anda int, istediğimiz anda guid, istediğimiz anda string olmasını sağlayacak yapı da bunun devamında tanımlayacağımız generic yapıyla beraber gerçekleştirilecek.

    //diğer katmanlarda da kullanacağımız için public olacak.
    public interface IEntity<T>
    {
        //Id: Verinin veritabanında PK olarak tanımlanmasını temsil edecek.
        //MasterId: Verinin UI'da ya da tedarikçilerde görüntülenmesi için kullanılacak. Master id guid olcak bir sonraki id tahmin edilemeyecek. API isteklerinde daha güvenli bir yapıda olması için kullanıldı. Kullanmak zorunda değiliz
        public int ID { get; set; }

        public T MasterId { get; set; }

        //Created (veri oluşturulduğu anda ortak olarak kullanılacak propertyler)
        public DateTime CreatedDate { get; set; } //verinin ne zaman oluşturulduğu
        public string CreatedComputerName { get; set; } //hangi bilgisayardan oluşturulduğu. windows r cmd komut işlemcisi who am i'daki bilgiyi yazıcaz
        public string CreatedIpAddress { get; set; } //hangi ip adresinden

        //Updated (veri güncellendiği zaman ortak olarak kullanılacak propertyler)

        public DateTime UpdatedDate { get; set; }

        public string UpdatedComputerName { get; set; }

        public string UpdatedIpAddress { get; set; }

        public bool IsActive { get; set; } //UI'da göstermek istemediğimiz şeyler olursa diye

        public DataStatus Status { get; set; }

    }
}
