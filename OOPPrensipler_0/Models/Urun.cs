using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrensipler_0.Models
{
    public class Urun
    {


        //Property'ler aslında veri sakladıgınız alanlar degildir...Property'ler arka tarafta gizli olan bir alana veri gönderen veya o alandan veri getiren aracılardır...

        //Property'ler siz hicbir şey yapmadıgınızda runtime'da otomatik olarak bir field(global degişken) acarlar...

        //Property'lerin get ve set metotlarına bir şey yazılmadığı sürece Encapsulation algoritması uygulamayı bekleyemezsiniz...ANcak ve ancak bu metotlardan herhangi biri üzerinde bir kontrol algoritması gerçekleştiginde veya bu metotlara bir müdahale bulunuldugunda bir Encapsulation prensibi uygulamıs olursunuz...

        //Biz normal şartlarda alttaki syntax'ta acılan property'lere autoproperty deriz...Bunlar bir Encapsulation uygulamayan, sadece RAM'den veri getiren veya  RAM'e veri atayabilen property'lerdir.

        //Property'lerdeki get ve set görevleri : 

        //get : İlgili property'den deger almaya calıstıgınızda calısan metottur...

        // set : İlgili property'nin deger atamasını istediginizde calısan bir metottur...


        //public Urun(string isim)
        //{
        //    UrunIsmi = isim;
        //}
        
        public string UrunIsmi { get; set; }//Bu şekilde acılan property'e Auto-Property denir...Yani siz property'e hicbir görev vermemişsinizdir...

       

        //--------------------------------------


        //Bir Encapsulation yapılacak ise Property kendisine kesinlikle hitap etmemelidir...CÜnkü öyle yaparsa bu sizi StackOverFlowException hatasına yonlendirir...Property'lerin hitap edecegi field artık özel olarak yaratılmak zorundadır...


        //Field'lar standart olarak alttire ile baslar ve camelCase devam eder...Public veya internal olmamalıdırlar...

        decimal _fiyat;

        public decimal Fiyat 
        {
            get  //get geriye deger döndüren bir metottur
            {
                //Dilerseniz burada da UnitPrice ile ilgili modifikasyon yapabilirsiniz...

                //Eger siz get'te veya set'te herhangi bir kontrol algoritması veya müdahale algoritması yapmıyorsanız o zaman yazdıgınız syntax kesinlikle bir Encapsulation Algoritması olmaz...

                if(_fiyat < 10)
                {
                    //BU tarz algoritmalarda dilerseniz hata fırlatmak yerine default bir deger döndürebilrsiniz...HAtta field'in degerini bile degiştirebilirsiniz...
                   MessageBox.Show($"Dikkat et ürün fiyatı bilgisinde bir yanlıslık var...Veritabanındaki veri corrupt olmus durumda...Dısarıdan size gelen fiyati {_fiyat}...Dilerseniz bunu veritabanı uzmanınızla görüşün...Program her halükarda güvenlik icin bunu default fiyata cekecektir");
                    _fiyat = 10;

                    //throw new Exception("Ürün fiyatı yanlıs olamaz dedik ne diye yanlıs bilgiler geliyor yahu");
                }
                return _fiyat;
            }

            set //deger atayan bir metottur...Geriye deger döndürmez...set aldıgı degeri value keyword'uyle anlar
            {
                if(value  < 10)
                {
                    throw new Exception("Fiyat 10'dan kücük olamaz"); //throw new Exception(); ifadesi yeni bir Exception nesnesi yaratarak (instance'i alarak) bunu programa fırlattırmaktır...
                }
                _fiyat = value;
            }
          
            
        
        
        }

    }
}
