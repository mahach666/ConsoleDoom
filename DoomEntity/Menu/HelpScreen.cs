using ConsoleDoom.DoomEntity.Event;
using ConsoleDoom.DoomEntity.Game;

namespace ConsoleDoom
{
    public sealed class HelpScreen : MenuDef
    {
        private int pageCount;

        private int page;

        public HelpScreen(DoomMenu menu) : base(menu)
        {
            if (menu.Options.GameMode == GameMode.Shareware)
            {
                pageCount = 2;
            }
            else
            {
                pageCount = 1;
            }
        }

        public override void Open()
        {
            page = pageCount - 1;
        }

        public override bool DoEvent(DoomEvent e)
        {
            if (e.Type != EventType.KeyDown)
            {
                return true;
            }

            if (e.Key == DoomKey.Enter ||
                e.Key == DoomKey.Space ||
                e.Key == DoomKey.LControl ||
                e.Key == DoomKey.RControl)
            {
                page--;
                if (page == -1)
                {
                    Menu.Close();
                }
                Menu.StartSound(Sfx.PISTOL);
            }

            if (e.Key == DoomKey.Escape)
            {
                Menu.Close();
                Menu.StartSound(Sfx.SWTCHX);
            }

            return true;
        }

        public int Page => page;
    }
}
