using System.Diagnostics;

namespace TemporaryFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tmp_dir = "D:\\Temporary";
            if (!Directory.Exists(tmp_dir))
            {
                Directory.CreateDirectory(tmp_dir);
            }
            DateTime now = DateTime.Now;
            string fold_1 = now.ToString("yyMM");
            fold_1 = $"{tmp_dir}\\{fold_1}";
            if (!Directory.Exists(fold_1))
            {
                Directory.CreateDirectory(fold_1);
            }
            string fold_2 = now.ToString("dd");
            fold_2 = $"{fold_1}\\{fold_2}";
            if (!Directory.Exists(fold_2))
            {
                Directory.CreateDirectory(fold_2);
            }
            Process.Start("explorer.exe", fold_2);
        }
    }
}
