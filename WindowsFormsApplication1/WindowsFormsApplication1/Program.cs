using System;
using System.Windows.Forms;
using System.Threading;

namespace ClipBoardUpdater
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                if (Clipboard.ContainsText())
                {
                    var textFromClipboard = Clipboard.GetText();

                    Clipboard.SetText(textFromClipboard.Replace("the", "the bean"));
                }

                Thread.Sleep(6000); //sleep for a min
            }
        }
    }
}