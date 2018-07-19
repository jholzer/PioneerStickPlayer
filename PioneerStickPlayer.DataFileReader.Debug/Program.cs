using System.Linq;
using PioneerStickPlayer.DataFileLogic;

namespace PioneerStickPlayer.DataFileReader.Debug
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = args.FirstOrDefault();

            var reader = new RekordBoxContentReader();
            reader.ReadContent(path);
        }
    }
}