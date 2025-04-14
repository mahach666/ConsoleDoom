using System;
using System.Text;

namespace ConsoleDoom.Video
{
    public static class AnsiRenderer
    {


        public static void PrintBGRA(byte[] buffer, int width, int height)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //int i = (y * width + x) * 4;
                    int i = (x * height + y) * 4;
                    byte b = buffer[i + 0];
                    byte g = buffer[i + 1];
                    byte r = buffer[i + 2];

                    int ansi = RgbToAnsi256(r, g, b);
                    Console.Write($"\x1b[48;5;{ansi}m  ");
                }
                Console.Write("\x1b[0m\n");
            }
            Console.Write("\x1b[0m");
        }

        public static void PrintBGRAFast(byte[] buffer, int width, int height,uint scale =1)
        {
            var sb = new StringBuilder(height * width * 10);
            for (int y = 0; y < height; y+= (int)scale)
            {
                for (int x = 0; x < width; x+= (int)scale)
                {
                    int i = (x * height + y) * 4;
                    byte r = buffer[i + 0];
                    byte g = buffer[i + 1];
                    byte b = buffer[i + 2];

                    int ansi = RgbToAnsi256(r, g, b);
                    sb.Append($"\x1b[48;5;{ansi}m  ");
                }
                sb.Append("\x1b[0m\n");
            }
            sb.Append("\x1b[0m");

            Console.SetCursorPosition(0, 0);
            Console.Write(sb.ToString());
        }


        public static int RgbToAnsi256(byte r, byte g, byte b)
        {
            int ir = (int)(r / 51.0); // 0–5
            int ig = (int)(g / 51.0);
            int ib = (int)(b / 51.0);
            return 16 + 36 * ir + 6 * ig + ib;
        }

        public static void PrintAscii(byte[] buffer, int width, int height)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    byte color = buffer[y * width + x];
                    Console.Write($"\x1b[48;5;{color}m  "); // двойной пробел цветом фона
                }
                Console.Write("\x1b[0m\n"); // сброс цвета + новая строка
            }

            Console.Write("\x1b[0m"); // окончательный сброс
        }
    }
}
