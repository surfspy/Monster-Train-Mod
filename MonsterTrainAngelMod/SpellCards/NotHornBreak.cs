using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MonsterTrainMod;
using Trainworks.Builders;
using Trainworks.Constants;

namespace MonsterTrainMod.SpellCards
{
    class NotHornBreak
    {
        public static string ID = TestPlugin.GUID + "_NotHornBReak";
        

        public static void Make()
        {
            CardDataBuilder railyard = new CardDataBuilder
            {
                CardID = NotHornBreak.ID,
                Name = "Not Horn Break",
                Description = "Deal [effect0.power] damage",
                Cost = 1,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = VanillaClanIDs.Clanless,
                AssetPath = "assets/nothornbreak.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                        ParamInt = 5,
                        TargetMode = TargetMode.DropTargetCharacter
                    }
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
                }
            };
            railyard.BuildAndRegister();
        }
    }
}