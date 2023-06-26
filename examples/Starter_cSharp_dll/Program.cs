// See https://aka.ms/new-console-template for more information
//using System.Runtime.InteropServices;
//
//Console.WriteLine("Hello, World!");

using System.Runtime.InteropServices;

class Program
{
    //[DllImport("libc.so.6")]
    //private static extern int getpid();
    [DllImport("..\\..\\..\\..\\..\\lib\\GetGudSdk.dll")]
    //cSharp-production\examples\Starter_cSharp_dll\bin\Debug\net6.0\Starter_cSharp_dll.exe
    private static extern int init();

    static void Main(string[] args)
    {
        int status = init();
        Console.WriteLine(status);

    }
}