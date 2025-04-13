using ConsoleDoom.DoomEntity;
using ConsoleDoom.DoomEntity.MathUtils;

namespace ConsoleDoom.Video
{
    public interface IVideo
    {
        public void Render(Doom doom, Fixed frameFrac);
        public void InitializeWipe();
        public bool HasFocus();

        public int MaxWindowSize { get; }
        public int WindowSize { get; set; }

        public bool DisplayMessage { get; set; }

        public int MaxGammaCorrectionLevel { get; }
        public int GammaCorrectionLevel { get; set; }

        public int WipeBandCount { get; }
        public int WipeHeight { get; }
    }
}
