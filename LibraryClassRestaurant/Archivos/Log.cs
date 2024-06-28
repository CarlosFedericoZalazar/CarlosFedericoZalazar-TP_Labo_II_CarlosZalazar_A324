using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Archivos
{
    public static class Log
    {
        private static string logFilePath = FilePathLog("log.txt");

        public static void Enter(string mensaje)
        {            
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                string textoLog = $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {mensaje}";
                writer.WriteLine(textoLog);
            }
        }

        private static string FilePathLog(string fileName)
        {
            string pathDestino = $@"C:\Users\Usuario\Desktop\SEGUNDA VERSION TP\LibraryClassRestaurant\Archivos\json";
            string filePath = Path.Combine(pathDestino, fileName);
            return filePath;
        }
    }

}
