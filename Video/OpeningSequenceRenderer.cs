using ConsoleDoom.DoomEntity.Graphics;
using ConsoleDoom.DoomEntity.MathUtils;
using ConsoleDoom.DoomEntity.Opening;
using ConsoleDoom.DoomEntity.Wad;

namespace ConsoleDoom.Video
{
    public class OpeningSequenceRenderer
    {
        private DrawScreen screen;
        private Renderer parent;

        private PatchCache cache;

        public OpeningSequenceRenderer(WadObj wad, DrawScreen screen, Renderer parent)
        {
            this.screen = screen;
            this.parent = parent;

            cache = new PatchCache(wad);
        }

        public void Render(OpeningSequence sequence, Fixed frameFrac)
        {
            var scale = screen.Width / 320;

            switch (sequence.State)
            {
                case OpeningSequenceState.Title:
                    screen.DrawPatch(cache["TITLEPIC"], 0, 0, scale);
                    break;

                case OpeningSequenceState.Demo:
                    parent.RenderGame(sequence.DemoGame, frameFrac);
                    break;

                case OpeningSequenceState.Credit:
                    screen.DrawPatch(cache["CREDIT"], 0, 0, scale);
                    break;
            }
        }
    }
}
