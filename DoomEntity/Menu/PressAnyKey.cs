using ConsoleDoom.Audio;
using ConsoleDoom.DoomEntity.Event;
using System;
using System.Collections.Generic;

namespace ConsoleDoom.DoomEntity.Menu
{
    public sealed class PressAnyKey : MenuDef
    {
        private string[] text;
        private Action action;

        public PressAnyKey(DoomMenu menu, string text, Action action) : base(menu)
        {
            this.text = text.Split('\n');
            this.action = action;
        }

        public override bool DoEvent(DoomEvent e)
        {
            if (e.Type == EventType.KeyDown)
            {
                if (action != null)
                {
                    action();
                }

                Menu.Close();
                Menu.StartSound(Sfx.SWTCHX);

                return true;
            }

            return true;
        }

        public IReadOnlyList<string> Text => text;
    }
}
