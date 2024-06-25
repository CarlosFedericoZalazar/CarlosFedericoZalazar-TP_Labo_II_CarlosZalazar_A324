using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Archivos
{
    public static class Serializador 
    {        
        public static void SaveJson<T>(string path, List<T> lista) 
        {             
            path = GetJsonFilePath(path)+".json"; // Ver donde guardamos los archivos
            using (var writer = new StreamWriter(path)) 
            {
                var option = new JsonSerializerOptions();
                option.WriteIndented = true;

                var json = JsonSerializer.Serialize(lista, option);
                writer.Write(json);
            }
        }

        private static List<T> ReadJson<T>(string path) 
        {
            path = GetJsonFilePath(path) + ".json";
            var lista = new List<T>();
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();

                    var listaAux = JsonSerializer.Deserialize<List<T>>(json);

                    if (listaAux != null)
                    {
                        foreach (var item in listaAux)
                        {
                            lista.Add(item);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<T> Read<T>(string path) 
        {
            return ReadJson<T>(path);
        }

        public static void Save<T>(string path, T item)
        {
            List<T> lista = ReadJson<T>(path);
            if (lista.Contains(item))
            {
                int index = lista.IndexOf(item);
                lista[index] = item;
            }
            else
            {
                lista.Add(item);
            }
            Serializador.SaveJson(path, lista);
        }


        private static string GetJsonFilePath(string fileName)
        {
            string pathDestino = $@"C:\Users\Usuario\Desktop\SEGUNDA VERSION TP\LibraryClassRestaurant\Archivos\json";
            string filePath = Path.Combine(pathDestino, fileName);
            return filePath;
        }
    }
}
