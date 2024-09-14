using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Helper
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file,string FolderName)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", FolderName);
            var fileName =$"{Guid.NewGuid()}-{file.FileName}";
            var filePath=Path.Combine(folderPath, fileName);
            using var FileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(FileStream);
                
            
            return filePath;
        }
    }
}
