using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Pratic
{
    public class SatisTemsilcisi : BaseKisi // SatisTemsilcisi: BaseKisi sınıfından türeyen bir alt sınıf.
    {
        public override void Gorev()  // Gorev metodu override edilerek Satış Temsilcisi'ne özgü bir mesaj yazdırılır.
        {
            Console.WriteLine("Ben satış temsilcisiyim");
        }
    }
}
