
namespace ValheimDamageTypesMod
{
	public class ValheimDamageTypesMod : Mod
    {
        public static Dictionary<string, string> list = [];
        public override void Load()
        {
            list["Fire"] =
                "FireArrow\nStarfury\nFallingStar\nBallofFire\nFlamarang\nFlamelash\nSunfury\nMeteorShot\nHellfireArrow\nFlamingArrow\nFlames\nCursedFlameFriendly\nCursedFlameHostile\nEyeFire\nCursedArrow\nCursedBullet\nFlare\nRocketFireworkRed\nRocketFireworkGreen\nRocketFireworkBlue\nRocketFireworkYellow\nFlamethrowerTrap\nFlamesTrap\nFireball\nEyeBeam\nHeatRay\nInfernoHostileBolt\nInfernoHostileBlast\nInfernoFriendlyBolt\nInfernoFriendlyBlast\nShadowflames\nFlamingWood\nGreekFire1\nGreekFire2\nGreekFire3\nFlamingScythe\nImpFireball\nMolotovCocktail\nMolotovFire\nMolotovFire2\nMolotovFire3\nRocketFireworksBoxRed\nRocketFireworksBoxGreen\nRocketFireworksBoxBlue\nRocketFireworksBoxYellow\nFireworkFountainYellow\nFireworkFountainRed\nFireworkFountainBlue\nFireworkFountainRainbow\nMeteor1\nMeteor2\nMeteor3\nSolarFlareChainsaw\nSolarFlareDrill\nSaucerDeathray\nPhantasmalDeathray\nChargedBlasterLaser\nCultistBossFireBall\nCultistBossFireBallClone\nHellwing\nShadowFlameArrow\nShadowFlame\nShadowFlameKnife\nStarWrath\nSpark\nStardustSoldierLaser\nHelFire\nCascade\nMinecartMechLaser\nDesertDjinnCurse\nSolarFlareRay\nSolarCounter\nSolarWhipSword\nSolarWhipSwordExplosion\nLastPrismLaser\nDaybreak\nGeyserTrap\nSpiritFlame\nDD2FlameBurstTowerT1Shot\nDD2FlameBurstTowerT2Shot\nDD2FlameBurstTowerT3Shot\nDD2DrakinShot\nDD2BetsyFireball\nDD2BetsyFlameBreath\nDD2PhoenixBowShot\nDD2BetsyArrow\nManaCloakStar\nBeeCloakStar\nStarVeilStar\nStarCloakStar\nSuperStar\nSuperStarSlash\nLavaRocket\nLavaGrenade\nLavaMine\nHallowBossLastingRainbow\nHallowBossRainbowStreak\nHallowBossDeathAurora\nFairyQueenSunDance\nFairyQueenHymn\nFairyQueenMagicItemShot\nFairyQueenRangedItemShot\nFlamingMace\nDaybreakExplosion\nStarCannonStar\nVolcano\nHorsemanPumpkin";



            //AssignDamage(list["Blunt"], DamageType.Blunt);
            //AssignDamage(list["Pierce"], DamageType.Pierce);
            //AssignDamage(list["Slash"], DamageType.Slash);
            AssignDamage(list["Fire"], DamageType.Fire);
            //AssignDamage(list["Frost"], DamageType.Frost);
            //AssignDamage(list["Poison"], DamageType.Poison);
            //AssignDamage(list["Lightning"], DamageType.Lightning);
            //AssignDamage(list["Spirit"], DamageType.Spirit);
        }
    }
}
