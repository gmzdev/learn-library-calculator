using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputOutputLibrary
{
    public class MessageBoxOutputService : IOutputService
    {
        public void WriteResult(string result)
        {
            MessageBox.Show(result);
        }
    }
}
