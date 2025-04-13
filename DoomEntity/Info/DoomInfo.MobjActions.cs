using ConsoleDoom.DoomEntity.World;

namespace ConsoleDoom.DoomEntity.Info
{
    public static partial class DoomInfo
    {
        private class MobjActions
        {
            public void BFGSpray(WorldObj world, Mobj actor)
            {
                world.WeaponBehavior.BFGSpray(actor);
            }

            public void Explode(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Explode(actor);
            }

            public void Pain(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Pain(actor);
            }

            public void PlayerScream(WorldObj world, Mobj actor)
            {
                world.PlayerBehavior.PlayerScream(actor);
            }

            public void Fall(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Fall(actor);
            }

            public void XScream(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.XScream(actor);
            }

            public void Look(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Look(actor);
            }

            public void Chase(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Chase(actor);
            }

            public void FaceTarget(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FaceTarget(actor);
            }

            public void PosAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.PosAttack(actor);
            }

            public void Scream(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Scream(actor);
            }

            public void SPosAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SPosAttack(actor);
            }

            public void VileChase(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.VileChase(actor);
            }

            public void VileStart(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.VileStart(actor);
            }

            public void VileTarget(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.VileTarget(actor);
            }

            public void VileAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.VileAttack(actor);
            }

            public void StartFire(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.StartFire(actor);
            }

            public void Fire(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Fire(actor);
            }

            public void FireCrackle(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FireCrackle(actor);
            }

            public void Tracer(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Tracer(actor);
            }

            public void SkelWhoosh(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SkelWhoosh(actor);
            }

            public void SkelFist(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SkelFist(actor);
            }

            public void SkelMissile(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SkelMissile(actor);
            }

            public void FatRaise(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FatRaise(actor);
            }

            public void FatAttack1(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FatAttack1(actor);
            }

            public void FatAttack2(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FatAttack2(actor);
            }

            public void FatAttack3(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.FatAttack3(actor);
            }

            public void BossDeath(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BossDeath(actor);
            }

            public void CPosAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.CPosAttack(actor);
            }

            public void CPosRefire(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.CPosRefire(actor);
            }

            public void TroopAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.TroopAttack(actor);
            }

            public void SargAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SargAttack(actor);
            }

            public void HeadAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.HeadAttack(actor);
            }

            public void BruisAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BruisAttack(actor);
            }

            public void SkullAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SkullAttack(actor);
            }

            public void Metal(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Metal(actor);
            }

            public void SpidRefire(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SpidRefire(actor);
            }

            public void BabyMetal(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BabyMetal(actor);
            }

            public void BspiAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BspiAttack(actor);
            }

            public void Hoof(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.Hoof(actor);
            }

            public void CyberAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.CyberAttack(actor);
            }

            public void PainAttack(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.PainAttack(actor);
            }

            public void PainDie(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.PainDie(actor);
            }

            public void KeenDie(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.KeenDie(actor);
            }

            public void BrainPain(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainPain(actor);
            }

            public void BrainScream(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainScream(actor);
            }

            public void BrainDie(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainDie(actor);
            }

            public void BrainAwake(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainAwake(actor);
            }

            public void BrainSpit(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainSpit(actor);
            }

            public void SpawnSound(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SpawnSound(actor);
            }

            public void SpawnFly(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.SpawnFly(actor);
            }

            public void BrainExplode(WorldObj world, Mobj actor)
            {
                world.MonsterBehavior.BrainExplode(actor);
            }
        }
    }
}
