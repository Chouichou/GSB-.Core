using System;
using System.Collections.Generic;
using System.Text;

namespace Utilisateurs
{//Channa
    public abstract class Region : IRegion
    {
        private int reg_id;
        private string reg_code;
        private string sec_code;
        private string reg_nom;

    }

      public int Reg_id
      {
            get { return reg_id; }
            set { reg_id = value ;}    

      }

      public int Reg_code
      {
            get { return reg_code; }
            set { reg_code = value ;}    

      }

      public int Sec_code
      {
            get { return sec_code; }
            set { sec_code = value ;}    

      }

      public int Reg_nom
      {
            get { return reg_nom; }
            set { reg_nom = value ;}    

      }

        // contructeur : 
      public Region(Reg_id reg_id,Reg_code reg_code, Sec_code sec_code,Reg_nom reg_nom)
      {
            this.reg_id = reg_id;
            this.reg_code = reg_code;
            this.sec_code = sec_code;
            this.reg_nom = reg_nom;

      }

}

