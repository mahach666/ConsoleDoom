using ConsoleDoom.UserInput;

namespace ConsoleDoom.DoomEntity.Event
{
    public sealed class DoomEvent
    {
        private EventType type;
        private DoomKey key;

        public DoomEvent(EventType type, DoomKey key)
        {
            this.type = type;
            this.key = key;
        }

        public EventType Type => type;
        public DoomKey Key => key;
    }
}
