using System;
using System.Runtime.InteropServices;
using PioneerStickPlayer.Interfaces.Enum;

namespace PioneerStickPlayer.Interfaces.FileDataStructs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FileHeaderEntry
    {
        public PageType PageType;
        public Int32 Empty;
        public Int32 FirstPage;
        public Int32 LastPage;

    }
}