using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TestSajetConnect
{
    class MES
    {
        [DllImport("SajetConnect.dll", EntryPoint = "CCMSajetConnect.SajetTransStart")]
        public static extern bool SajetTransStart();

        [DllImport("SajetConnect.dll", EntryPoint = "CCMSajetConnect.SajetTransClose")]
        public static extern bool SajetTransClose();

        [DllImport("SajetConnect.dll", EntryPoint = "CCMSajetConnect.SajetTransData")]
        public static extern bool SajetTransData(short f_iCommandNo, ref byte f_pData, ref int f_pLen);

        [DllImport("SajetConnect.dll", EntryPoint = "CCMSajetConnect.SajetTransData")]
        public static extern bool SajetTransData(short f_iCommandNo, ref string f_pData, ref int f_pLen);
    }
}
