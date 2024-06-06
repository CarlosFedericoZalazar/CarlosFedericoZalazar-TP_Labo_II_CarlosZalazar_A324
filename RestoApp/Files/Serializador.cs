using RestoApp.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestoApp.Files
{
    public class Serializador
    {
        // Serializa un objeto a JSON y lo guarda en un archivo

        public class Archivo
        {
            public static void SaveJson<T>(string path, List<T> lista) 
            {
                //path = $"C:\\Users\\Usuario\\Desktop\\TpLaboratorio II\\AppRestoForm\\Files\\{path}.json";
                path = GetJsonFilePath(path)+".json";
                using (var writer = new StreamWriter(path)) //Combine(file))) 
                {
                    var option = new JsonSerializerOptions();
                    option.WriteIndented = true;

                    var json = JsonSerializer.Serialize(lista, option);
                    writer.Write(json);
                }
            }

            public static BindingList<T> ReadJson<T>(string path)
            {
                path = GetJsonFilePath(path) + ".json";
                //path = $"C:\\Users\\Usuario\\Desktop\\TpLaboratorio II\\AppRestoForm\\Files\\{path}.json";
                var lista = new BindingList<T>(); // Cambio List<T> a BindingList<T>

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
                                lista.Add(item); // Agregar cada elemento de listaAux a personas
                            }
                        }
                    }
                }
                return lista;

            }
        }

        public static string GetJsonFilePath(string fileName)
        {
            string pathDestino = $"C:\\Users\\Usuario\\Desktop\\TpLaboratorio II\\AppRestoForm\\Files";

            string carpetaNombre = fileName.ToUpper();

            // Crear el path completo de la carpeta
            string carpetaPath = Path.Combine(pathDestino, carpetaNombre);

            // Crear la carpeta si no existe
            if (!Directory.Exists(carpetaPath))
            {
                Directory.CreateDirectory(carpetaPath);
            }

            // Crear el path completo del archivo
            string filePath = Path.Combine(carpetaPath, fileName);
            return filePath;
        }

        public static void Save<T>(T item, string path)
        {
            List<T> lista = Archivo.ReadJson<T>(path).ToList();
            lista.Add(item);
            Save(lista, path);
        }
        public static void Save<T>(List<T> item, string path)
        {
            Serializador.Archivo.SaveJson<T>(path, item);
        }
    }
}
