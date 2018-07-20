using System.Runtime.InteropServices;

namespace PioneerStickPlayer.Interfaces.FileDataStructs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FileHeader
    {
        public int PageSize;
        public int PageEntries;
        public int NextUnusedPage;
        public int Unknown;
        public int Sequence;

    }
}