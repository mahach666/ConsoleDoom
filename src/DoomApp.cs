using ConsoleDoom.UserInput;
using ConsoleDoom.Utils;
using ConsoleDoom.Video;
using DoomNetFrameworkEngine;
using DoomNetFrameworkEngine.DoomEntity;
using DoomNetFrameworkEngine.DoomEntity.Game;
using DoomNetFrameworkEngine.DoomEntity.MathUtils;
using DoomNetFrameworkEngine.Video;
using System;
using System.Linq;

namespace RevitDoomNetPort
{
    public class DoomApp
    {
        public string IwadPath;
        public bool HighResolution;
        public string[] ExtraArgs;
        public uint Scale;

        public void Run()
        {
            try
            {
                ConsoleHelper.EnableVirtualTerminalProcessing();
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                var argsList = new[] { "-iwad", IwadPath };
                if (ExtraArgs.Length > 0)
                {
                    argsList = new string[] { "-iwad", IwadPath }.Concat(ExtraArgs).ToArray();
                }

                var cmdArgs = new CommandLineArgs(argsList);
                var config = new Config();
                config.video_highresolution = HighResolution;
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
                    AnsiRenderer.PrintBGRAFast(buffer, width, height, Scale);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
