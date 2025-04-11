using ManagedDoom.Video;
using ManagedDoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedDoom.ConsoleVideo;
using ManagedDoom.Audio;
using ManagedDoom.UserInput;

namespace RevitDoomNetPort
{
    public static class Class1
    {
        public static void Main(string[] args)
        {
            try
            {
                var cmdArgs = new CommandLineArgs(new[] { "-iwad", "DOOM1.WAD" });
                var config = new Config();
                config.video_highresolution = false;
                var content = new GameContent(cmdArgs);

                // Создаём Doom без Silk
                var doom = new ManagedDoom.Doom(cmdArgs, config, content, null, null, null, null);

                // Запускаем игру (например, E1M1)
                doom.NewGame(GameSkill.Medium, 1, 1);

                // Создаём рендерер напрямую
                var renderer = new Renderer(config, content);
                var width = renderer.Width;
                var height = renderer.Height;
                var buffer = new byte[4 * width * height]; // BGRA по 4 байта

                // Несколько кадров фона
                for (int frame = 0; frame < 1000000; frame++)
                {
                    doom.Update();

                    // Заполняем буфер кадром
                    renderer.Render(doom, buffer, Fixed.Zero);

                    // <-- Поставь тут breakpoint и смотри buffer в отладчике

                    System.Threading.Thread.Sleep(33);
                }

                Console.WriteLine("Рендер завершён. Проверь buffer в отладчике.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e);
            }
        }
    }
}
