using System.Runtime.InteropServices;

namespace PioneerStickPlayer.Interfaces.FileDataStructs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FileHeader
    {
        [FieldOffset(4)]
        public int PageSize;
        [FieldOffset(8)]
        public int PageEntries;
        [FieldOffset(12)]
        public int NextUnusedPage;
        [FieldOffset(16)]
        public int Unknown;
        [FieldOffset(24)]
        public int Sequence;

    }
}