using System.IO;
using System.Linq;
using PioneerStickPlayer.Interfaces.Enum;
using PioneerStickPlayer.Interfaces.FileDataStructs;
using PioneerStickPlayer.Interfaces.Model;
using PioneerStickPlayer.Interfaces.Services;

namespace PioneerStickPlayer.DataFileLogic
{
    public class RekordBoxContentReader : IRekordBoxContentReader
    {
        public RekordBoxContent ReadContent(string pdbFilePath)
        {
            using (var reader = new BinaryReader(File.OpenRead(pdbFilePath)))
            {
                var headerEntries = ReadHeader(reader);

                // TODO: Read pages here!
            }

            return null;
        }

        private static FileHeaderEntry[] ReadHeader(BinaryReader reader)
        {
            var buffer = ReadPage(reader);

            var header = buffer.ToStruct<FileHeader>(4);

            var headerEntries = Enumerable.Range(0, header.PageEntries)
                .Select(entryId => buffer.ToStruct<FileHeaderEntry>(44 + entryId * 32)) // Is this offset matching? Must be evaluated...
                .ToArray();
            return headerEntries;
        }

        private static byte[] ReadPage(BinaryReader reader)
        {
            byte[] buffer = new byte[4096];
            reader.Read(buffer, 0, 4096);
            return buffer;
        }
    }
}
