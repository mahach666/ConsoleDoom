using ConsoleDoom.DoomEntity.Event;
using System;
using System.Collections.Generic;

namespace ConsoleDoom
{
    public sealed class YesNoConfirm : MenuDef
    {
        private string[] text;
        private Action action;

        public YesNoConfirm(DoomMenu menu, string text, Action action) : base(menu)
        {
            this.text = text.Split('\n');
            this.action = action;
        }

        public override bool DoEvent(DoomEvent e)
        {
            if (e.Type != EventType.KeyDown)
            {
                return true;
            }

            if (e.Key == DoomKey.Y ||
                e.Key == DoomKey.Enter ||
                e.Key == DoomKey.Space)
            {
                action();
                Menu.Close();
                Menu.StartSound(Sfx.PISTOL);
            }

            if (e.Key == DoomKey.N ||
                e.Key == DoomKey.Escape)
            {
                Menu.Close();
                Menu.StartSound(Sfx.SWTCHX);
            }

            return true;
        }

        public IReadOnlyList<string> Text => text;
    }
}
