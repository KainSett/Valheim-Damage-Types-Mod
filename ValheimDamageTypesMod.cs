
namespace ValheimDamageTypesMod
{
	public class ValheimDamageTypesMod : Mod
    {
        public static Dictionary<string, string> list = [];
        public override void Load()
        {
            list["Fire"] =
                "FireArrow Starfury FallingStar BallofFire Flamarang Flamelash Sunfury MeteorShot HellfireArrow FlamingArrow Flames CursedFlameFriendly CursedFlameHostile EyeFire CursedArrow CursedBullet Flare RocketFireworkRed RocketFireworkGreen RocketFireworkBlue RocketFireworkYellow FlamethrowerTrap FlamesTrap Fireball EyeBeam HeatRay InfernoHostileBolt InfernoHostileBlast InfernoFriendlyBolt InfernoFriendlyBlast Shadowflames FlamingJack FlamingWood GreekFire1 GreekFire2 GreekFire3 FlamingScythe ImpFireball MolotovCocktail MolotovFire MolotovFire2 MolotovFire3 RocketFireworksBoxRed RocketFireworksBoxGreen RocketFireworksBoxBlue RocketFireworksBoxYellow FireworkFountainYellow FireworkFountainRed FireworkFountainBlue FireworkFountainRainbow Meteor1 Meteor2 Meteor3 SolarFlareChainsaw SolarFlareDrill SaucerDeathray PhantasmalDeathray ChargedBlasterLaser CultistBossFireBall CultistBossFireBallClone Hellwing ShadowFlameArrow ShadowFlame ShadowFlameKnife StarWrath Spark StardustSoldierLaser HelFire Cascade MinecartMechLaser DesertDjinnCurse SolarFlareRay SolarCounter SolarWhipSword SolarWhipSwordExplosion LastPrismLaser Daybreak GeyserTrap SpiritFlame DD2FlameBurstTowerT1Shot DD2FlameBurstTowerT2Shot DD2FlameBurstTowerT3Shot DD2DrakinShot DD2BetsyFireball DD2BetsyFlameBreath DD2PhoenixBowShot DD2BetsyArrow ManaCloakStar BeeCloakStar StarVeilStar StarCloakStar SuperStar SuperStarSlash LavaRocket LavaGrenade LavaMine HallowBossLastingRainbow HallowBossRainbowStreak HallowBossDeathAurora FairyQueenSunDance FairyQueenHymn FairyQueenMagicItemShot FairyQueenRangedItemShot FlamingMace DaybreakExplosion StarCannonStar Volcano HorsemanPumpkin";

            list["Blunt"] =
                "Bone Bomb Dynamite Grenade SandBallFalling StickyBomb AshBallFalling MudBall SandBallGun Tombstone EbonsandBallFalling EbonsandBallGun PearlSandBallFalling PearlSandBallGun SiltBall IceBlock Boulder BombSkeletronPrime Explosives GrenadeI RocketI ProximityMineI GrenadeII RocketII ProximityMineII GrenadeIII RocketIII ProximityMineIII GrenadeIV RocketIV ProximityMineIV BeachBall CannonballFriendly Landmine SlushBall GraveMarker CrossGraveMarker Headstone Gravestone Obelisk CannonballHostile CrimsandBallFalling BoulderStaffOfEarth ChlorophyteJackhammer GolemFist ExplosiveBunny PaladinsHammerHostile PaladinsHammerFriendly RocketSkeleton JackOLantern OrnamentFriendly RocketSnowmanI RocketSnowmanII RocketSnowmanIII RocketSnowmanIV OrnamentHostile Present CrimsandBallGun SpiderEgg Anchor StickyGrenade Flairon MiniSharkron FlaironBubble Bubble CopperCoinsFalling SilverCoinsFalling GoldCoinsFalling PlatinumCoinsFalling Meteor1 Meteor2 Meteor3 Xenopopper PhantasmalEye PhantasmalSphere SeedlerNut ";

            AssignDamage(list["Fire"], DamageType.Blunt | DamageType.Fire);
            //AssignDamage(list["Blunt"], DamageType.Blunt);
            //AssignDamage(list["Pierce"], DamageType.Pierce);
            //AssignDamage(list["Slash"], DamageType.Slash);
            //AssignDamage(list["Fire"], DamageType.Fire);
            //AssignDamage(list["Frost"], DamageType.Frost);
            //AssignDamage(list["Poison"], DamageType.Poison);
            //AssignDamage(list["Lightning"], DamageType.Lightning);
            //AssignDamage(list["Spirit"], DamageType.Spirit);
        }
    }
}
