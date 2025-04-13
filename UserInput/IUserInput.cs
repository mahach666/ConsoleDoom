using ConsoleDoom.DoomEntity.Game;

namespace ConsoleDoom.UserInput
{
    public interface IUserInput
    {
        void BuildTicCmd(TicCmd cmd);
        void Reset();
        void GrabMouse();
        void ReleaseMouse();

        public int MaxMouseSensitivity { get; }
        public int MouseSensitivity { get; set; }
    }
}
