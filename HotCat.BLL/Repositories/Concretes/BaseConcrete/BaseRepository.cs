using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.DAL.Context;
using HotCat.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace HotCat.BLL.Repositories.Concretes.BaseConcrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HotCatContext _context;
        private DbSet<T> _entities; //sürekli cast işlemi yapmamak için

        public BaseRepository(HotCatContext context) 
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task<string> Create(T entity) // Parametreden alınan entity'i veritabanın ekler ve bir string değer döner.
        {
            try
            {
                entity.Status = Model.Enums.DataStatus.INSERTED;
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
                return "Kayıt işlemi başarılı.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> Delete(T entity) // Delete işlemi veritabanında veriyi doğrudan kaldırmaz, verinin durumunu Deleted olarak değiştirir. Yani kalıcı olarak silmez.
        {
            try
            {
                entity.Status = Model.Enums.DataStatus.DELETED;
                Update(entity);
                return "Silme işlemi başarılı.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> Update(T entity) // Parametreden almış olduğu veriyi doğrudan veritabanında günceller.
        {
            string result = "";

            switch (entity.Status)
            {
                case Model.Enums.DataStatus.DELETED:
                    entity.Status = Model.Enums.DataStatus.DELETED;

                    //EntityFramework ile birlikte bize sunulan Entry() isimli metot paramaternin değerlerini veritabanındaki değerler ile otomatik olarak karşılaştırır eğer değişiklik görürse o değişikliği kendisi otomatik gerçekleştirir.

                    //_context veritabanını temsil ettiği için 

                    _context.Entry(entity).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = "Veri Güncellendi";

                    break;

                case Model.Enums.DataStatus.INSERTED:
                    entity.Status = Model.Enums.DataStatus.UPDATED;
                    _context.Entry(entity).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = "Veri Güncellendi";
                    break;
                case Model.Enums.DataStatus.UPDATED:
                    entity.Status = Model.Enums.DataStatus.UPDATED;
                    _context.Entry(entity).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = "Veri Güncellendi";
                    break;
            }

            return result;
        }

        public async Task<string> DestroyData(T entity) // Veritabanından veriyi komple kaldırmak için kullanılır.
        {
            _entities.Remove(entity);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return "Veri kalıcı olarak silindi.";
            }
            else
            {
                return "Hata meydana geldi.";
            }
        }

        public IEnumerable<T> GetActives() // Aktif olan verileri liste olarak teslim eder.
        {
            return _entities.Where(x => x.IsActive == true).ToList();
        }

        public IEnumerable<T> GetAll() // Bütün verileri getirir
        {
            return _entities.ToList();
        }

        public T GetById(int id) // Parametreden almış olduğu ID'ye göre veriyi tekil olarak teslim eder.
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<T> GetPassives() // Pasif olarak tanımlanan verileri liste halinde teslim eder.
        {
            return _entities.Where(x => x.IsActive == false).ToList(); 
        }

    }
}
