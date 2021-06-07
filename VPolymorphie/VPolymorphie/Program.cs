using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPolymorphie.VePo;

namespace VPolymorphie
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string N, pr, pro;
        //    int ag;
        //    Personne p = new Personne(); // ici on a utilise le constructeur par defaut

        //    Console.WriteLine("donne le Nom : ");
        //    N = Console.ReadLine();
        //    p.setnom(N);

        //    Console.WriteLine("donne le prenom : ");
        //    pr = Console.ReadLine();
        //    p.setprenom(pr);

        //    Console.WriteLine("donne l'age : ");
        //    ag =int.Parse(Console.ReadLine() ) ; // conversion en entier
        //    p.setage(ag);

        //    Console.WriteLine(p.sepresenter());
        //    Console.ReadKey(); // pour garder la console



        //}
        // DEuxiemem Maniere de faire la meme chose
        static void Main(string[] args)
        {
            string N, pr, pro;
            int ag;
           

            Console.WriteLine("donne le Nom : ");
            N = Console.ReadLine();
           // p.setnom(N);

            Console.WriteLine("donne le prenom : ");
            pr = Console.ReadLine();
           // p.setprenom(pr);

            Console.WriteLine("donne l'age : ");
            ag = int.Parse(Console.ReadLine()); // conversion en entier
                                                // p.setage(ag);
            Personne p = new Personne(N, pr, ag); // ici on  utilise le constructeur avec les 3 parametres

            Console.WriteLine(p.sepresenter());
            Console.ReadKey(); // pour garder la console



        }
    }
}
