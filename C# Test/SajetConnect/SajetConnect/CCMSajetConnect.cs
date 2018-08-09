using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSFramework.Common;

namespace SajetConnect
{
    public class CCMSajetConnect
    {
        public   bool SajetTransStart()
        {
            return CCMMES.SajetTransStart();
        }
        public   bool SajetTransClose()
        {
            return CCMMES.SajetTransClose();
        }

        public   bool SajetTransData(short f_iCommandNo, ref byte f_pData, ref int f_pLen)
        {
            IniFile iFile = new IniFile("Sajet.ini");
            String  ITerminal = iFile.ReadString("Test Station", "Terminal ID", "0");
            String SendData = ITerminal + ";"+Convert.ToString(f_pData,f_pLen) ;
            byte[] str = new byte[1024];
            char[] mychar = SendData.ToCharArray();
            int mylen;
            for (int i = 0; i < mychar.Length; i++)
            {
                str[i] = Convert.ToByte(Convert.ToInt32(mychar[i]));
            }
            mylen = str.Length;
            return CCMMES.SajetTransData(f_iCommandNo, ref str[0], ref mylen);

        }

        public   bool SajetTransData(short f_iCommandNo, ref string f_pData, ref int f_pLen)
        {
            return CCMMES.SajetTransData(f_iCommandNo, ref f_pData, ref f_pLen);
        }

    }
}
