using System;
using System.Runtime.InteropServices;

namespace PioneerStickPlayer.DataFileLogic
{
    static class ByteArrayExtensions
    {
        public static T ToStruct<T>(this byte[] array, int offset = 0)
        {
            var structureType = typeof(T);

            int size = Marshal.SizeOf(structureType);
            if (array.Length < offset + size)
                throw new ArgumentException("Buffer not initalized correctly");

            byte[] tmp = new byte[size];
            Array.Copy(array, offset, tmp, 0, size);

            GCHandle structHandle = GCHandle.Alloc(tmp, GCHandleType.Pinned);
            object structure = Marshal.PtrToStructure(structHandle.AddrOfPinnedObject(), structureType);
            structHandle.Free();

            return (T)structure;
        }
    }
}