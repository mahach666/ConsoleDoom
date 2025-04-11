using ManagedDoom.Video;
using ManagedDoom;
using System;

public sealed class ConsoleVideo : IVideo, IDisposable
{
    private Renderer renderer;
    private byte[] buffer;
    private int width;
    private int height;

    public ConsoleVideo(Config config, GameContent content)
    {
        Console.Write("Initialize video: ");

        renderer = new Renderer(config, content);
        width = renderer.Width;
        height = renderer.Height;
        buffer  = new byte[width * height];


        Console.Clear();
        Console.CursorVisible = false;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("OK");
    }

    public void Render(Doom doom, Fixed frameFrac)
    {

        renderer.Render(doom, buffer, frameFrac);

        int scaleY = 4;
        int scaleX = 2;

        for (int y = 0; y < height; y += scaleY)
        {
            for (int x = 0; x < width; x++)
            {
                int i = y * width + x;
                byte brightness = buffer[i];
                char c = ColorToChar(brightness);
                for (int s = 0; s < scaleX; s++) Console.Write(c); // выводим два раза
            }
            Console.WriteLine();
        }
    }

    private char ColorToChar(byte b)
    {
        if (b >= 240) return '█';
        if (b >= 200) return '▓';
        if (b >= 160) return '▒';
        if (b >= 120) return '░';
        if (b >= 80) return '.';
        if (b >= 40) return ',';
        return ' ';
    }


    public void Resize(int width, int height) { }

    public void InitializeWipe() => renderer.InitializeWipe();

    public bool HasFocus() => true;

    public void Dispose() => Console.WriteLine("Shutdown video.");

    public int WipeBandCount => renderer.WipeBandCount;
    public int WipeHeight => renderer.WipeHeight;
    public int MaxWindowSize => renderer.MaxWindowSize;

    public int WindowSize
    {
        get => renderer.WindowSize;
        set => renderer.WindowSize = value;
    }

    public bool DisplayMessage
    {
        get => renderer.DisplayMessage;
        set => renderer.DisplayMessage = value;
    }

    public int MaxGammaCorrectionLevel => renderer.MaxGammaCorrectionLevel;

    public int GammaCorrectionLevel
    {
        get => renderer.GammaCorrectionLevel;
        set => renderer.GammaCorrectionLevel = value;
    }
}
