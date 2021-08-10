using System;
using Interfaces;

namespace Services
{
    public class AddContentService : IAddContentService
    {
        public void AddContent(string content)
        {
            Console.WriteLine($"Added content: {content}");
        }
    }
}
