using NarutoMod;
using RimWorld;
using TaranMagicFramework;
using Verse;

namespace BlazeNarutoAdditions
{
    [StaticConstructorOnStartup]
    public static class BlazePatch
    {
        static BlazePatch()
        {
            LongEventHandler.QueueLongEvent(Initialize, "Loading Blaze additions...", false, null);
        }

        private static void Initialize()
        {
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouIZ);
        }
    }


    [DefOf]
    public static class BlazeDefOf
    {
        public static AbilityTreeDef WN_MangekyouIZ;
    }
}