using System.IO;

namespace StudentAdminPortal.API.Repositories
{
    public class LocalStorageImageRepository : IImageRepository
    {
        public async Task<string> Upload(IFormFile file, string fileName)
        {
            //var filrPath=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName); 
            var filrPath = Path.Combine(Directory.GetCurrentDirectory(),@"Resources\Images", fileName);
            using Stream fileStream=new FileStream(filrPath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return GetServerRelativePath(fileName);
        }
        private string GetServerRelativePath(string fileName) 
        {
            return Path.Combine(@"Resources\Images", fileName);
        }
    }
}
