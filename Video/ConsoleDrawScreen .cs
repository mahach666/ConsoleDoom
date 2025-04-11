using System;
using ManagedDoom.Video;

namespace ManagedDoom.ConsoleVideo
{
    public class ConsoleDrawScreen : DrawScreen
    {
        private readonly char[,] buffer;
        private readonly int width;
        private readonly int height;

        public ConsoleDrawScreen(int width, int height) : base(null, width, height)
        {
            this.width = width;
            this.height = height;
            buffer = new char[height, width];
        }

        public override void FillRect(int x, int y, int w, int h, int color)
        {
            for (int i = y; i < y + h && i < height; i++)
            {
                for (int j = x; j < x + w && j < width; j++)
                {
                    if (i >= 0 && j >= 0)
                        buffer[i, j] = ' ';
                }
            }
        }

        public override void DrawLine(float x1, float y1, float x2, float y2, int color)
        {
            int ix1 = (int)Math.Round(x1);
            int iy1 = (int)Math.Round(y1);
            int ix2 = (int)Math.Round(x2);
            int iy2 = (int)Math.Round(y2);

            int dx = Math.Abs(ix2 - ix1), sx = ix1 < ix2 ? 1 : -1;
            int dy = -Math.Abs(iy2 - iy1), sy = iy1 < iy2 ? 1 : -1;
            int err = dx + dy, e2;

            while (true)
            {
                if (ix1 >= 0 && ix1 < width && iy1 >= 0 && iy1 < height)
                    buffer[iy1, ix1] = '#';

                if (ix1 == ix2 && iy1 == iy2) break;
                e2 = 2 * err;
                if (e2 >= dy) { err += dy; ix1 += sx; }
                if (e2 <= dx) { err += dx; iy1 += sy; }
            }
        }

        public override void DrawText(string text, int x, int y, int scale)
        {
            for (int i = 0; i < text.Length && x + i < width; i++)
            {
                if (y >= 0 && y < height)
                    buffer[y, x + i] = text[i];
            }
        }

        public override void DrawPatch(Patch patch, int x, int y, int scale)
        {
            if (x >= 0 && x < width && y >= 0 && y < height)
                buffer[y, x] = '*';
        }

        public override void DrawPatchFlip(Patch patch, int x, int y, int scale)
        {
            DrawPatch(patch, x, y, scale);
        }

        public override void DrawChar(char ch, int x, int y, int scale)
        {
            if (x >= 0 && x < width && y >= 0 && y < height)
                buffer[y, x] = ch;
        }

        public override int MeasureChar(char ch, int scale)
        {
            return 1;
        }

        public override int MeasureText(string text, int scale)
        {
            return text.Length;
        }

        public void Show()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write(buffer[i, j] == '\0' ? ' ' : buffer[i, j]);
                Console.WriteLine();
            }
        }
    }
}
