using InterfacesLibrary;
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
