using BepInEx;
using HarmonyLib;
using TrainworksModdingTools;
using System;
using Trainworks.Interfaces;
using Trainworks.Managers;
using MonsterTrainMod.SpellCards;

namespace MonsterTrainMod
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("tools.modding.trainworks")]
    public class TestPlugin : BaseUnityPlugin, IInitializable
    {
        public const string GUID = "com.name.package.Test";
        public const string NAME = "Test Plugin";
        public const string VERSION = "0.0.1";

        private void Awake()
        {
            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }
        public void Initialize()
        {
            TestSpell.Make();
            NotHornBreak.Make();

        }

        [HarmonyPatch(typeof(SaveManager), "SetupRun")]
        class AddCardToStartingDeckPatch
        {
            static void Postfix(ref SaveManager __instance)
            {
                var id = TestPlugin.GUID + "_TestSpell";
                __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(id));
            }
        }
    }
}
