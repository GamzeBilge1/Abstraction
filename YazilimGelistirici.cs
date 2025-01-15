using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Pratic
{
    public class YazilimGelistirici:BaseKisi
    {
        public override void Gorev() // YazilimGelistirici: BaseKisi sınıfından türeyen bir alt sınıf.
        {
            Console.WriteLine("Ben yazılım geliştiriciyim.");  // Gorev metodu override edilerek Yazılım Geliştirici'ye özgü bir mesaj yazdırılır.
        }
    }
}
