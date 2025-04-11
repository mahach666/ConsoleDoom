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
        public static void Main()
        {
            // Загружаем конфигурацию и ресурсы
            var config = new Config();

            var wad = new Wad("DOOM1.WAD");

            //config.video_screenheight = 50;
            //config.video_screenwidth = 100;
            config.video_highresolution = false;

            var args = new CommandLineArgs(new string[] { "-iwad", "DOOM1.WAD" }); // путь к WAD
            var content = new GameContent( args);

            // Создаём видео-вывод в консоль
            //var video = new ConsoleVideo(config, content);
            var video = new DrawScreen(wad, 256,144);

            // Создаём Doom-движок
            //var doom = new ManagedDoom.Doom(config, content, video);

            var doom = new ManagedDoom.Doom(args, config, content, video, null, null, null);

            // Игровой цикл (упрощённый)
            while (true)
            {
                video.Render(doom, new Fixed(30));
                System.Threading.Thread.Sleep(33); // ~30 FPS
                Console.Clear();
            }
        }
    }
}
