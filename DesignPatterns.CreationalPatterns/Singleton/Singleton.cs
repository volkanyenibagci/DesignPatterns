using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        // Constructor'ı private yaparak dışarıdan nesne oluşturulmasını engeller.
        private Singleton()
        { }

        // Nesnenin tek bir örneğini oluşturup döndüren statik metot.
        public static Singleton GetInstance()
        {
            // Eğer örnek daha önce oluşturulmamışsa yeni bir örnek oluştur.
            if (instance == null)
            {
                instance = new Singleton();
            }
            // Mevcut örneği döndür.
            return instance;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Hello from the Singleton class!");
        }
    }
}