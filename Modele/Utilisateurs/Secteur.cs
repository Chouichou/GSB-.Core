using System;
using System.Collections.Generic;
using System.Text;

namespace Utilisateurs
{//Channa
    class Secteur
    {
        private int sec_id;
        private string sec_code;
        private string sec_libelle;


    public int sec_id
     {
            get { return sec_id; }
            set { sec_id = value ;}    

     }
    public string sec_code
     {
            get { return sec_code; }
            set { sec_code = value ;}    

     }

    public string Sec_libelle
     {
            get { return sec_libelle; }
            set { sec_libelle = value ;}    

     }



    public Secteur(Sec_id sec_id,Sec_code sec_code, Sec_libelle sec_libelle)
     {
            this.sec_id = sec_id;
            this.sec_code = sec_code;
            this.sec_libelle = sec_libelle;

     }

    }
}
