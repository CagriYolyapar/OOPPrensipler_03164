using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrensipler_0.Models
{
    public class Category
    {
        //CategoryName'in metninin 8 karakterden az olmamasını saglayın...metin.Length size int tipinde karakter sayısını döndürür...Eger textbox'tan girilen CategoryName 8 karakterden azsa karakter sayısı en az 8 olmalıdır hatası verilsin...

        //Encapsulation yapmamızın 3 Yöntemi vardır : 

        // 1 => Property Based Encapsulation

        // 2 => Constructor Based Encapsulation

        // 3 => Customized Encapsulation

        //public Category(string categoryName) //Constructor based injection
        //{
        //    if (categoryName.Length < 8) throw new Exception("8 karakterden az veriyle baslayamazsınız");
        //    CategoryName = categoryName;
        //}

        //public string CategoryName { get; set; }

        public Category(string categoryName)
        {
           CategoryName = categoryName;
        }



        string _categoryName;

        public string CategoryName
        {
            get
            {
                if (_categoryName.Length < 8)
                {
                    throw new Exception("Kaynak degerde hata var");
                }
                return _categoryName;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Girdiginiz karakter sayısı 8'den kücük olamaz");
                }
                _categoryName = value;
            }

        }


        public string GetCategoryName()
        {
            if(_categoryName.Length < 8)
            {
                throw new Exception("CategoryName'de hata var");
            }
            return _categoryName;
        }


        public void SetCategoryName(string categoryName)
        { 
            if(categoryName.Length < 8)
            {
                throw new Exception("Karakter sayısı 8'den az olamaz");
            }
            _categoryName = categoryName;
        }






    }
}
