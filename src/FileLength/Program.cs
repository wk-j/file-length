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
            var files = Directory.EnumerateFiles(path.FullName, "*.*");

            foreach (var item in files) {
                var info = new FileInfo(item);
                var length = Encoding.UTF8.GetBytes(info.Name).Length;
                if (length > maxLength) {
                    Console.WriteLine($"{info.FullName} (Length={length})");
                }
            }
        }
    }
}
