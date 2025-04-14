using RevitDoomNetPort.Utils;

namespace ConsoleDoom
{
    public static class App
    {
        public static void Main(string[] args)
        {
            var wadPath = UserSelect.GetWad();

            var builder = new AppBuilder();
            builder.SetIwad("DOOM1.WAD")
                .EnableHighResolution(false)
                .WithArgs("-skill", "3");

            var app = builder.Build();
            app.Run();
        }
    }
}
