using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Golovanov_tomogram_visualizer
{
    internal class Bin
    {
        public static int X, Y, Z;
        public static short[] array;
        public void ReadBIN(string path)
        {
            if (File.Exists(path))
            {
                BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                Z = reader.ReadInt32();
                int arraySize = X* Y * Z;
                array = new short[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = reader.ReadInt16();
                }
            }
        }
    }
}
