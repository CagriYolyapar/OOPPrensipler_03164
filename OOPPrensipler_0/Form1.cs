using OOPPrensipler_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrensipler_0
{
    public partial class Form1 : Form
    {


        #region Prensipler

        /*
         

                  OOP felsefesinin tam anlamıyla uygulanabilmesi icin sadece class acmak (hatta OOP'yi destekleyen diger yapıları da acmak) bize yetmez...

        OOP felsefesinin bize sunduğu avantajları (extendibility(genişletilebilirlik), reusability(Tekrar kullanılabilirlik), maintainability(sürdürülebilirlik)) gercekleştirebilmesi icin icerisinde 4 temel prensip, 5 Advanced prensip vardır...

        Temel Prensipler

        Encapsulation(Kapsülleme)
        Inheritance(Miras alma/verme)
        Polymorphism(Cok bicimlilik)
        Abstraction(Veri Soyutlama)


        Advanced Prensipler(SOLID Prensipler)

        S => Single Responsibility(Tekil Sorumluluk)
        O => Open Closed(Acık Kapalı)
        L => Liskov's Substitituion (Liskov'un Yerine Gecme Prensibi)
        I => Interface Segregation (Interface Ayrımı)
        D => Dependency Inversion (Bagımlılık Gevseklestirilmesi)
         
                    
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         */






        #endregion


        /*
                           --Encapsulation 

        1 => Class'ın ögelerine yapılan erişimin kontrol altına alınmasını ve bu kontrolün class'ın kendisi tarafından yapılmasını saglayan bir prensiptir(Seperation of Concerns - Sorumlulukların ayrılması felsefesini uygular)
         

        2=> Aynı zamanda normal şartlar altında ayrıntılı davranısların tek tek calıstıgı sistemlerde bu davranısların tek bir merkezden tetiklenmesini saglayarak işlemleri daha kontrollü bir hale getirir...
         
         
         
         
         
         
         */







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Category c = new Category("Tatlılar");

            
            //c.CategoryName = "asdadsasad";

            try
            {
                Urun u = new Urun();
                u.UrunIsmi = "Tadelle";

                //MessageBox.Show(u.UrunIsmi);

                // u.Fiyat = 0;
                MessageBox.Show(u.Fiyat.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
