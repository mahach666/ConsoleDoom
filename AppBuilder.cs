using ConsoleDoom.Utils;
using ConsoleDoom.Video;
using ConsoleDoom.DoomEntity;
using System;
using System.Linq;
using ConsoleDoom.DoomEntity.Game;

namespace ConsoleDoom
{
    public class AppBuilder
    {
        private string iwadPath = "DOOM1.WAD";
        private bool highResolution = false;
        private string[] extraArgs = Array.Empty<string>();

        public AppBuilder SetIwad(string path)
        {
            iwadPath = path;
            return this;
        }

        public AppBuilder EnableHighResolution(bool enable = true)
        {
            highResolution = enable;
            return this;
        }

        public AppBuilder WithArgs(params string[] args)
        {
            extraArgs = args;
            return this;
        }

        public void Run()
        {
            try
            {
                ConsoleHelper.EnableVirtualTerminalProcessing();
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                var argsList = new[] { "-iwad", iwadPath };
                if (extraArgs.Length > 0)
                {
                    argsList = new string[] { "-iwad", iwadPath }.Concat(extraArgs).ToArray();
                }

                var cmdArgs = new CommandLineArgs(argsList);
                var config = new Config();
                config.video_highresolution = highResolution;
                var content = new GameContent(cmdArgs);

                ConsoleUserInput input = null;
                Doom doom = null;

                input = new ConsoleUserInput(config, e => doom?.PostEvent(e));
                doom = new Doom(cmdArgs, config, content, null, null, null, input);

                var renderer = new Renderer(config, content);

                int width = renderer.Width;
                int height = renderer.Height;
                var buffer = new byte[4 * width * height];

                Console.Clear();

                while (true)
                {
                    Console.SetCursorPosition(0, 0);

                    if (doom.Menu.Active || doom.State != DoomState.Game)
                    {
                        input.PollMenuKeys();
                    }

                    doom.Update();
                    renderer.Render(doom, buffer, Fixed.Zero);
                    AnsiRenderer.PrintBGRAFast(buffer, width, height, 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e);
            }
        }
    }
}
