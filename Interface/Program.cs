using Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //AÇIKLAMA
    //*Interface, tüm entitiylerde şu methodlar olmak zorunda ! diyebilmemizi sağlar, Interface içine bir kod yazılamaz.Sadece methodların isimlerini saklar ve diğer classlara rehber görevi görür

    class Program
    {
        static void Main(string[] args)
        {

            IMainInterface x = new Customer();
            Console.WriteLine(x.ShowMessage());


            x = new Product();
            Console.WriteLine(x.ShowMessage());


            Console.Read();


        }
    }
}
