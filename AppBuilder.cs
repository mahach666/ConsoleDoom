using RevitDoomNetPort;
using System;

namespace ConsoleDoom
{
    public class AppBuilder
    {
        private DoomApp _app = new DoomApp;
        private string _iwadPath = "DOOM1.WAD";
        private bool _highResolution = false;
        private string[] _extraArgs = Array.Empty<string>();

        public AppBuilder SetIwad(string path)
        {
            _app.IwadPath = path;
            return this;
        }

        public AppBuilder EnableHighResolution(bool enable = true)
        {
            _app.HighResolution = enable;
            return this;
        }

        public AppBuilder WithArgs(params string[] args)
        {
            _app.ExtraArgs = args;
            return this;
        }

        public DoomApp Build()
        {
            return _app;
        }
    }
}
