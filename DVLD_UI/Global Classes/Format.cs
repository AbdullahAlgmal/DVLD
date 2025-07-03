using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_UI.Global_Classes
{
    public class Format
    {
        public static string DateToShort(DateTime Dt) => Dt.ToString("dd/MMM/yyyy");
    }
}
