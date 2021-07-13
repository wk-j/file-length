using System;
using System.IO;
using System.Text;

namespace FileLength {
    class Program {
        /// <summary>
        ///
        /// </summary>
        /// <param name="path"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        static void Main(DirectoryInfo path, int maxLength = 255) {
            var files = Directory.EnumerateFiles(path.FullName, "*.*", SearchOption.AllDirectories);

            var index = 1;
            foreach (var item in files) {
                var info = new FileInfo(item);
                var fileName = info.Name;
                var length = Encoding.UTF8.GetBytes(fileName).Length;
                if (length > maxLength) {
                    Console.WriteLine($"{index++.ToString("D3")}) {info.FullName} (Length={fileName.Length}, Byte={length})");
                }
            }
        }
    }
}
