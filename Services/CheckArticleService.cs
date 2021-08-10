using System;
using Interfaces;

namespace Services
{
    public class CheckArticleService : ICheckArticleService
    {
        public void CheckArticle(string property)
        {
            Console.WriteLine($"Checked article by property: {property}");
        }
    }
}
