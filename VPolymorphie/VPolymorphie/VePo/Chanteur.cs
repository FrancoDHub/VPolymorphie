using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPolymorphie.VePo
{
    class Chanteur :Personne
    {
        public Chanteur(string n,string p,int ag)

              : base(n, p, ag) // herite du constructeur de la classe personne
                               // appel du constructeur de la classe Personne
                               // le mot-clé "base" permet d'accéder à la classe Personne

        {

            setprofession("Chanteur"); //j'adapte la propriete setprofession a la classe chanteur

            
        }
        public override string sepresenter()  //c'est la redefinition par oveeride
        {
            return base.sepresenter() + "je suis chanteur ";  // return base  = retour la methode de la classe mere
        }
    }
}
