using System;
using System.IO;
using System.Web;


namespace PM3
{
    internal class Program
    {
        static string Out_name(String a)
        {
            return Path.GetFileName(a);
        }

        static void Main(string[] args)
        {

            Logger.InitLogger();
            string filePath = "C:\\Users\\satoa\\source\\repos\\PM3\\bin\\Debug\\net6.0\\PM.txt"; // Путь к файлу, который ты хочешь проверить
            CheckFileAccess(filePath);
            //string out_name = Path.GetFileName(filePath);
        }

        static void CheckFileAccess(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Logger.ErrorLog.Error($"Файл {filePath} не найден по указанному пути");
                    return;
                }

                Logger.Log.Info($"Файл {filePath} пути найден, производится раскрытие в самом существе");

                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    Logger.Log.Info($" {Out_name(filePath)} раскрытие в существе произведено успешно");


                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string content = reader.ReadToEnd();

                        Logger.Log.Info($"Содержимое файла {Out_name(filePath)}: {content}");
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Logger.ErrorLog.Error($"Нет доступа к файлу {Out_name(filePath)}: {ex.Message}");
            }
            catch (IOException ex)
            {
                Logger.ErrorLog.Error($"Ошибка Доступ к файлу запрещён {Out_name(filePath)}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Logger.ErrorLog.Error($"Произошла ошибка при раскрытии в самом существе {Out_name(filePath)}: {ex.Message}");
            }
        }
    }

}
