using ManagedDoom;
using ManagedDoom.Video;
using RevitDoomNetPort.Utils;
using RevitDoomNetPort.Video;
using System;

namespace RevitDoomNetPort
{
    public static class Class1
    {
        public static void Main(string[] args)
        {
            try
            {
                ConsoleHelper.EnableVirtualTerminalProcessing();


                var cmdArgs = new CommandLineArgs(new[] { "-iwad", "DOOM1.WAD" });
                var config = new Config();
                config.video_highresolution = false;
                var content = new GameContent(cmdArgs);

                var input = new ConsoleUserInput();

                // Создаём Doom без Silk
                var doom = new ManagedDoom.Doom(cmdArgs, config, content, null, null, null, input);

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
                    Console.SetCursorPosition(0, 0);
                    doom.Update();

                    // Заполняем буфер кадром
                    Console.WriteLine($"State: {doom.State}, Game: {doom.Game?.State}, World: {doom.Game?.World != null}");


                    renderer.Render(doom, buffer, Fixed.One);

                    AnsiRenderer.PrintBGRAFast(buffer, width, height, 1);

                    // <-- Поставь тут breakpoint и смотри buffer в отладчике

                    //System.Threading.Thread.Sleep(33);
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
