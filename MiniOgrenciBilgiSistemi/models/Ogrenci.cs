using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOgrenciBilgiSistemi.models
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }


        public ICollection<OgrenciDers> OgrenciDersler { get; set; }

        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        //Buradaki sinif property'si terminolojide "navigation property" olarak geçer. Amacıysa Ogrenci modelinin Sinif modeliyle arasında bir ilişki olduğunu belirtmektir. Ancak burada bunu yaparak ilişkiyi tanımlanış olmuyoruz, olacak bir ilişkiyi sağlayabilmek için diğer class ile bir köprü bağlantı yaratıyoruz. Tekrardan, buradaki navigation property'sinin amacı bir ilişki tanımlayacak olduğumuzda bunu yapabilmemizi sağlayan bir referans yaratmaktır. İlişkimizi fluent api ile yaratacağız, dolayısıyla Context class'ımız içerisindeki OnModelCreating fonksiyonunda modelBuilder parametresi üzerinden ilişkimizi kuracağız.
    }
}

/*

--> Bu Ogrenci class'ındaki "Sinif" Navigation Property'sinin hakkında açıklama:

Buradaki  sinif property'si bir "Navigation Property'dir.
Navigation property'leri, iki model arasında gezinebilmek için referanslar sağlar ve bu sayede ilişkili veriler arasında gezinmek mümkün olur.
Navigation property ile burada yapılan şey: Ogrenci modelinin Sinif modeliyle olan ilişkisini belirtmek ve Sinif modeline bir referans sağlamaktır.
Bu referans sadece C# düzeyinde oluşur, ancak veritabanındaki ilişkilerin kurulabilmesi için Fluent API ile ek konfigürasyon yapılmalıdır.

 */
