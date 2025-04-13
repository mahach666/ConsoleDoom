using ConsoleDoom.DoomEntity.Game;
using ConsoleDoom.DoomEntity.World;

namespace ConsoleDoom.DoomEntity.Info
{
    public static partial class DoomInfo
    {
        private class PlayerActions
        {
            public void Light0(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Light0(player);
            }

            public void WeaponReady(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.WeaponReady(player, psp);
            }

            public void Lower(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Lower(player, psp);
            }

            public void Raise(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Raise(player, psp);
            }

            public void Punch(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Punch(player);
            }

            public void ReFire(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.ReFire(player);
            }

            public void FirePistol(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FirePistol(player);
            }

            public void Light1(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Light1(player);
            }

            public void FireShotgun(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FireShotgun(player);
            }

            public void Light2(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Light2(player);
            }

            public void FireShotgun2(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FireShotgun2(player);
            }

            public void CheckReload(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.CheckReload(player);
            }

            public void OpenShotgun2(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.OpenShotgun2(player);
            }

            public void LoadShotgun2(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.LoadShotgun2(player);
            }

            public void CloseShotgun2(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.CloseShotgun2(player);
            }

            public void FireCGun(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FireCGun(player, psp);
            }

            public void GunFlash(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.GunFlash(player);
            }

            public void FireMissile(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FireMissile(player);
            }

            public void Saw(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.Saw(player);
            }

            public void FirePlasma(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FirePlasma(player);
            }

            public void BFGsound(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.A_BFGsound(player);
            }

            public void FireBFG(WorldObj world, Player player, PlayerSpriteDef psp)
            {
                world.WeaponBehavior.FireBFG(player);
            }
        }
    }
}
