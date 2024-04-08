using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FileAndStreamIO
{
    public class FileFactory
    {
        public bool LuuFile(List<SinhVien> dssv, string path)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt) | *.txt";
                sfd.ShowDialog();
                FileStream f = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dssv);
                f.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
