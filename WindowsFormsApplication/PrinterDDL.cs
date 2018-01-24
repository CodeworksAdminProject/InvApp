using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace WindowsFormsApplication
{
    public class TSCLIB_DLL
    {
        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport(@"\dll_AND_picture\TSCLIB.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);

    }
}