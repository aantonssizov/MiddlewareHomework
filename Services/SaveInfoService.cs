using System;
using Interfaces;

namespace Services
{
    public class SaveInfoService : ISaveInfoService
    {
        public void SaveInfo()
        {
            Console.WriteLine("Saved Info about article");
        }
    }
}
