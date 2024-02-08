using System;
using System.IO;

namespace Utils.JsonDatabase
{
    public class CostumerDb
    {
        public string DirectoryPath;
        public string Message;
        public bool IsSuccess;

        public CostumerDb(string directoryPath)
        {
            IsSuccess = true;
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                DirectoryPath = directoryPath;
                Message = string.Empty;
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                Message = $"Erro: {ex.Message}";
            }
        }

        public void Include(string id, string json)
        {
            IsSuccess = true;
            try
            {
                var filePath = $"{DirectoryPath}\\{id}.json";
                if (File.Exists(filePath))
                {
                    IsSuccess = false;
                    Message = $"Erro: Arquivo com ID: {id} já existe";
                }
                else
                {
                    File.WriteAllText(filePath, json);
                    IsSuccess = true;
                    Message = string.Empty;
                }
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                Message = $"Erro: {ex.Message}";
            }
        }

        public void Update(string id, string json)
        {
            IsSuccess = true;
            try
            {
                var filePath = $"{DirectoryPath}\\{id}.json";
                if (!File.Exists(filePath))
                {
                    IsSuccess = false;
                    Message = $"Erro: Arquivo com ID: {id} não encontrado";
                }
                else
                {
                    File.Delete(filePath);
                    File.WriteAllText(filePath, json);
                    IsSuccess = true;
                    Message = string.Empty;
                }
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                Message = $"Error: {ex.Message}";
            }
        }

        public string FindOne(string id)
        {
            IsSuccess = true;
            try
            {
                var filePath = $"{DirectoryPath}\\{id}.json";
                if (!File.Exists(filePath))
                {
                    IsSuccess = false;
                    Message = $"Erro: ID: {id} não encontrado";
                }
                else
                {
                    var content = File.ReadAllText(filePath);
                    return content;
                }
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                Message = $"Erro: {ex.Message}";
            }
            return "";
        }

        public void Delete(string id)
        {
            IsSuccess = true;
            try
            {
                var filePath = $"{DirectoryPath}\\{id}.json";
                if (!File.Exists(filePath))
                {
                    IsSuccess = false;
                    Message = "Erro: Arquivo não encontrado";
                }
                else
                {
                    File.Delete(filePath);
                    IsSuccess = true;
                    Message = string.Empty;
                }
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                Message = $"Erro: {ex.Message}";
            }
        }
    }
}
