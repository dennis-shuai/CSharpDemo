using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            String FileName=@"C:\SajetConnect.ini";
            Console.WriteLine(File.Exists(FileName));
            String DirPath = @"C:\";
            Console.WriteLine(Directory.Exists(DirPath));
            if (!File.Exists( FileName))
            {
                FileStream rf = new FileStream(FileName, FileMode.Create);
                BinaryWriter w = new BinaryWriter(rf);
                int[] arr = { 1, 3, 6, 8, 12, 34 };
                foreach (var i in arr)
                {
                    w.Write(i.ToString()); 
                }
                w.Close();
                rf.Close();
            } else
            {
                using (StreamWriter sw =  File.AppendText(FileName))
                {
                    string [] strArray = {"Hello","World","I","Love","You"};
                    foreach( var i in strArray){
                        sw.WriteLine(i);
                        sw.Flush();
                    }
                    sw.Close();
                }
            }

           //using( FileStream fs= new FileStream(FileName,FileMode.Open,FileAccess.
           //     Read)){
           //     using (BinaryReader br= new BinaryReader(fs))
           //     {
           //         String s;
           //         while ((s = br.ReadString())!= null)
           //         {
           //             Console.WriteLine(s);
           //         }
           //         br.Close();
                     
           //     }
           //     fs.Close();

           // }

            using (StreamReader sr=File.OpenText(FileName))
            {
                String s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                sr.Close();
            }

            
            Console.ReadLine();
        }
    }
}
