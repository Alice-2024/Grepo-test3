using System.Diagnostics;

class Program1
{
    static void Main()
    {
        try
        {
            // Use verbatim string literal to avoid unrecognized escape sequence errors
            Process.Start(@"C:\Program Files\Microsoft Visual Studio\18\Insiders\Common7\IDE\devenv.exe");
            Console.WriteLine("Visual Studio 已启动。");
        }
        catch (Exception ex)
        {
            Console.WriteLine("启动失败: " + ex.Message);
            const string errorMessage = "请检查路径是否正确，并确保 Visual Studio 已安装。";
        }
    }
}
// Visual Studio 可执行文件路径
//string vsPath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";

