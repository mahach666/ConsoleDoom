using ConsoleDoom.DoomEntity.Game;

namespace ConsoleDoom.UserInput
{
    public sealed class NullUserInput : IUserInput
    {
        private static NullUserInput instance;

        public static NullUserInput GetInstance()
        {
            if (instance == null)
            {
                instance = new NullUserInput();
            }

            return instance;
        }

        public void BuildTicCmd(TicCmd cmd)
        {
            cmd.Clear();
        }

        public void Reset()
        {
        }

        public void GrabMouse()
        {
        }

        public void ReleaseMouse()
        {
        }

        public int MaxMouseSensitivity
        {
            get
            {
                return 9;
            }
        }

        public int MouseSensitivity
        {
            get
            {
                return 3;
            }

            set
            {
            }
        }
    }
}
