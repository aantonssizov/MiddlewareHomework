using System;
using Interfaces;

namespace Services
{
    public class UploadArticleService : IUploadArticleService
    {
        public void UploadArticle()
        {
            Console.WriteLine("Uploaded article");
        }
    }
}
