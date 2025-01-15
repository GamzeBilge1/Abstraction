using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Pratic
{
    public abstract class BaseKisi  // BaseKisi: Çalışanlar için ortak özellikler ve metotları barındıran abstract sınıf.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract void Gorev(); // Abstract metot: Her çalışan kendine özgü bir görev tanımı yapacaktır.
    }
}
