using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Golovanov_tomogram_visualizer
{
    internal class View
    {
        private int VBOTexture;
        Bitmap textureImage;
        public int Min { get; set; } = 0;
        public int Shirina { get; set; } = 255;
        public void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Z, -1, 1);
            GL.Viewport(0, 0, width, height);
        }
        private Color TransferFunction(short value)
        {
            int min = Min;
            int max = Min+Shirina;
            int newVal = Clamp((value - min) * 255 / (max - min));
            return Color.FromArgb(255, newVal, newVal, newVal);
        }
        private int Clamp(int v, int min = 0, int max = 255)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }
        public void DrawQuads(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for (int x_coord = 0; x_coord < Bin.X-1; x_coord++)
                for (int z_coord = 0; z_coord < Bin.Z-1; z_coord++)
                {
                    short value;
                    //1 вершина
                    value = Bin.array[x_coord + layerNumber * Bin.X
                                                    + Bin.Y * Bin.X * z_coord];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, z_coord);

                    //2 вершина
                    value = Bin.array[x_coord + (layerNumber+1) * Bin.X
                                                    + z_coord * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, z_coord + 1);

                    //3 вершина
                    value = Bin.array[x_coord+1 + (layerNumber + 1) * Bin.X
                                                    + z_coord * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord+1, z_coord + 1);

                    //4 вершина
                    value = Bin.array[x_coord+1 + layerNumber * Bin.X
                                                    + z_coord * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord+1, z_coord);
                }
            GL.End();
        }
        public void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOTexture);
            BitmapData data = textureImage.LockBits(
                new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            textureImage.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter,
                (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter,
                (int)TextureMagFilter.Linear);

            ErrorCode er = GL.GetError();
            string str = er.ToString();
        }
        public void GenerateTextureImage(int layerNumber)
        {
            textureImage = new Bitmap(Bin.X, Bin.Z);
            for (int i = 0; i < Bin.X; ++i)
                for(int j = 0; j < Bin.Z; ++j)
                {
                    int pixelNumber = i + layerNumber * Bin.X + j * Bin.X * Bin.Y;
                    textureImage.SetPixel(i, j, TransferFunction(Bin.array[pixelNumber]));  
                }
        }
        public void DrawTexture()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOTexture);

            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);
            GL.TexCoord2(0f, 0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0);
            GL.End();

            GL.Disable(EnableCap.Texture2D);
        }
    }
}
