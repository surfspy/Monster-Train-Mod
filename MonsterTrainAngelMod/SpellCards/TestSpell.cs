using System.Collections.Generic;
using Trainworks.Builders;
using Trainworks.Constants;

namespace MonsterTrainMod.SpellCards
{
    class TestSpell
    {
        public static string ID = TestPlugin.GUID + "_TestSpell";

        public static void Make()
        {
            new CardDataBuilder
            {
                
                CardID = ID,
                Name = "Test Spell",
                Description = "Deal [effect0.power] damage.",                
                Cost = 1,
                Rarity = CollectableRarity.Uncommon,
                AssetPath = "assets/nothornbreak.png",
                
                TargetsRoom = true,
                Targetless = false,
                ClanID = VanillaClanIDs.Clanless,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes,
                        ParamInt = 10,
                    }
                },

                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
                }
            }.BuildAndRegister();
            
        }
    }
}
