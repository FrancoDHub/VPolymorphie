using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPolymorphie.VePo
{
    class Personne
        // les attibuts
    {
        private string nom;
        private string prenom;
        private int age;
        private string profession;


        //les getters et le setters pour accedder a ses attibuts  En C#, les accesseurs prennent la forme de propriétés. Une propriété se manipule comme un champ,

        public string getnom() // un accesseur en lecture (getter) permet de lire la valeur d'un attribut.
        {
            return this.nom;
               
        }
        public void setnom(string n) // un accesseur en écriture(mutateur ou setter) permet de modifier la valeur d'un attribut.
        {
            this.nom = n;
        }

        public string getprenom()
        {
            return this.prenom;


        }
        public void setprenom(string p)
        {
            this.prenom = p;
        }
        public int getage()
        {
            return this.age;


        }
        public void setage(int a)
        {
            this.age = a;
        }
        public string getprofession()
        {
            return this.profession;


        }
        public void setprofession(string profession)
        {
            this.profession = profession;
        }

        //les constructeurs: le constructeur est une méthode spécifique dont le rôle est de construire un objet, le plus souvent en initialisant ses attributs.

        // Constructeur par défaut
        // L'utilisation d'un constructeur se fait au moment de l'instanciation de l'objet (opérateur new), en passant en paramètres les futures valeurs des attributs de l'objet créé.
        public Personne()
        {

        }

        public Personne(string pnom,string pprenom,int page)
        {
            this.nom = pnom;
            this.prenom = pprenom;
            this.age = page;
            this.profession = "";

        }
        public Personne(string pnom,string pprenom)
        {
            this.nom = pnom;
            this.prenom = pprenom;
            this.age = -1;
            this.profession = "";
                
        }
        public Personne(string pnom, string pprenom, int page,string pprofession)
        {
            this.nom = pnom;
            this.prenom = pprenom;
            this.age = page;
            this.profession = pprofession;

        }
        public virtual string sepresenter() // pour redefinir une methode dans la classe fille il fAUT le definir virtual:

        {
            if (this.age == -1)
            {
                return "je m'appelle " + this.nom + " " + this.prenom;
            }
            else
            {
                return "je m'appelle " + this.nom + " " + this.prenom + " " + " j'ai " +  this.age.ToString() + " ans "; // Tostring retourne un string
            }
        }
    }
}
