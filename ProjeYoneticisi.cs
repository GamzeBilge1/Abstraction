﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Pratic
{
    public class ProjeYoneticisi : BaseKisi     // ProjeYoneticisi: BaseKisi sınıfından türeyen bir alt sınıf.
    {
   
        public override void Gorev() // Gorev metodu override edilerek Proje Yöneticisi'ne özgü bir mesaj yazdırılır.
        {
            Console.WriteLine("Proje yöneticisiyim.");
        }

    }
}
