using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class EmlakService
    {
        private EmlakRepository emlakRepository = new EmlakRepository();

        private readonly EmlakRepository _emlakRepository;

        public EmlakService()
        {
            _emlakRepository = new EmlakRepository();
        }
        public List<Emlak> GetEmlakList()
        {
            // İş mantığını burada uygulayabilirsiniz, örneğin filtreleme veya doğrulama işlemleri
            return emlakRepository.GetAllProperties();
            
        }


        public void AddEmlak(Emlak yeniEmlak)
        {
            emlakRepository.AddEmlak(yeniEmlak);
        }
        public void DeleteEmlak(string adres)
        {
            emlakRepository.DeleteEmlak(adres);
        }

        public void UpdateEmlak(string eskiAdres, Emlak emlak)
        {
            emlakRepository.UpdateEmlak(eskiAdres, emlak); // DAL'daki metoda doğru parametreleri gönderiyoruz
        }


    }

}
