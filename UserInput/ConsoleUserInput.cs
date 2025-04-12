using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ManagedDoom;
using ManagedDoom.UserInput;

public class ConsoleUserInput : IUserInput
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int vKey);

    private static bool IsKeyDown(ConsoleKey key) => (GetAsyncKeyState((int)key) & 0x8000) != 0;

    public void PostEvent(DoomEvent e) { }

    public void BuildTicCmd(TicCmd cmd)
    {
        cmd.Clear();

        int speed = 1;

        if (IsKeyDown(ConsoleKey.W))
            cmd.ForwardMove += (sbyte)PlayerBehavior.ForwardMove[speed];
        if (IsKeyDown(ConsoleKey.S))
            cmd.ForwardMove -= (sbyte)PlayerBehavior.ForwardMove[speed];
        if (IsKeyDown(ConsoleKey.A))
            cmd.SideMove -= (sbyte)PlayerBehavior.SideMove[speed];
        if (IsKeyDown(ConsoleKey.D))
            cmd.SideMove += (sbyte)PlayerBehavior.SideMove[speed];

        if (IsKeyDown(ConsoleKey.Q))
            cmd.AngleTurn += (short)PlayerBehavior.AngleTurn[speed];
        if (IsKeyDown(ConsoleKey.E))
            cmd.AngleTurn -= (short)PlayerBehavior.AngleTurn[speed];

        if (IsKeyDown(ConsoleKey.Spacebar))
            cmd.Buttons |= TicCmdButtons.Attack;
        if (IsKeyDown(ConsoleKey.F))
            cmd.Buttons |= TicCmdButtons.Use;

        for (int i = 1; i <= 7; i++)
        {
            if (IsKeyDown((ConsoleKey)((int)ConsoleKey.D1 + i - 1)))
            {
                cmd.Buttons |= TicCmdButtons.Change;
                cmd.Buttons |= (byte)((i - 1) << TicCmdButtons.WeaponShift);
                break;
            }
        }
    }

    public void Reset() { }
    public void GrabMouse() { }
    public void ReleaseMouse() { }
    public void Dispose() { }

    public int MaxMouseSensitivity => 15;
    public int MouseSensitivity { get => 5; set { } }
}


//using System;
//using System.Collections.Generic;
//using ManagedDoom;
//using ManagedDoom.UserInput;

//public class ConsoleUserInput : IUserInput
//{
//    private readonly HashSet<DoomKey> currentFrameKeys = new HashSet<DoomKey>();

//    public ConsoleUserInput()
//    {
//        Console.TreatControlCAsInput = true;
//    }

//    public void PostEvent(DoomEvent e) { }

//    public void BuildTicCmd(TicCmd cmd)
//    {
//        cmd.Clear();
//        currentFrameKeys.Clear();

//        while (Console.KeyAvailable)
//        {
//            var key = Console.ReadKey(true);
//            if (TryConvertKey(key.Key, out DoomKey doomKey))
//            {
//                currentFrameKeys.Add(doomKey);
//            }
//        }

//        foreach (var key in currentFrameKeys)
//        {
//            switch (key)
//            {
//                case DoomKey.W:
//                    cmd.ForwardMove += (sbyte)PlayerBehavior.ForwardMove[1];
//                    break;
//                case DoomKey.S:
//                    cmd.ForwardMove -= (sbyte)PlayerBehavior.ForwardMove[1];
//                    break;
//                case DoomKey.A:
//                    cmd.SideMove -= (sbyte)PlayerBehavior.SideMove[1];
//                    break;
//                case DoomKey.D:
//                    cmd.SideMove += (sbyte)PlayerBehavior.SideMove[1];
//                    break;
//                case DoomKey.Q:
//                    cmd.AngleTurn += (short)PlayerBehavior.AngleTurn[1];
//                    break;
//                case DoomKey.E:
//                    cmd.AngleTurn -= (short)PlayerBehavior.AngleTurn[1];
//                    break;
//                case DoomKey.Space:
//                    cmd.Buttons |= TicCmdButtons.Attack;
//                    break;
//                case DoomKey.F:
//                    cmd.Buttons |= TicCmdButtons.Use;
//                    break;
//                case DoomKey.Num1:
//                case DoomKey.Num2:
//                case DoomKey.Num3:
//                case DoomKey.Num4:
//                case DoomKey.Num5:
//                case DoomKey.Num6:
//                case DoomKey.Num7:
//                    cmd.Buttons |= TicCmdButtons.Change;
//                    cmd.Buttons |= (byte)(((int)key - (int)DoomKey.Num1) << TicCmdButtons.WeaponShift);
//                    break;
//            }
//        }
//    }

//    private bool TryConvertKey(ConsoleKey key, out DoomKey doomKey)
//    {
//        switch (key)
//        {
//            case ConsoleKey.W: doomKey = DoomKey.W; return true;
//            case ConsoleKey.S: doomKey = DoomKey.S; return true;
//            case ConsoleKey.A: doomKey = DoomKey.A; return true;
//            case ConsoleKey.D: doomKey = DoomKey.D; return true;
//            case ConsoleKey.Spacebar: doomKey = DoomKey.Space; return true;
//            case ConsoleKey.F: doomKey = DoomKey.F; return true;
//            case ConsoleKey.Q: doomKey = DoomKey.Q; return true;
//            case ConsoleKey.E: doomKey = DoomKey.E; return true;
//            case ConsoleKey.D1: doomKey = DoomKey.Num1; return true;
//            case ConsoleKey.D2: doomKey = DoomKey.Num2; return true;
//            case ConsoleKey.D3: doomKey = DoomKey.Num3; return true;
//            case ConsoleKey.D4: doomKey = DoomKey.Num4; return true;
//            case ConsoleKey.D5: doomKey = DoomKey.Num5; return true;
//            case ConsoleKey.D6: doomKey = DoomKey.Num6; return true;
//            case ConsoleKey.D7: doomKey = DoomKey.Num7; return true;
//            default:
//                doomKey = DoomKey.Unknown;
//                return false;
//        }
//    }

//    public void Reset() => currentFrameKeys.Clear();
//    public void GrabMouse() { }
//    public void ReleaseMouse() { }
//    public void Dispose() { }

//    public int MaxMouseSensitivity => 15;
//    public int MouseSensitivity { get => 5; set { } }
//}