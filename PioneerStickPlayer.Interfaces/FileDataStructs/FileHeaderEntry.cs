using System;
using PioneerStickPlayer.Interfaces.Enum;

namespace PioneerStickPlayer.Interfaces.FileDataStructs
{
    public struct FileHeaderEntry
    {
        public PageType PageType;
        public Int32 Empty;
        public Int32 FirstPage;
        public Int32 LastPage;

    }
}