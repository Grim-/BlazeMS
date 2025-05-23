using NarutoMod;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaranMagicFramework;
using Verse;

namespace BlazeAdditions
{
    [StaticConstructorOnStartup]
    public static class BlazePatch
    {
        static BlazePatch()
        {
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouIZ);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouBA);

            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouME);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouNA);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouNI);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouRA);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouRS);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouSA);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouSE);
            WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouSN);
        }
    }
    [DefOf]
    public static class BlazeDefOf
    {
        public static AbilityTreeDef WN_MangekyouIZ;
        public static AbilityTreeDef WN_MangekyouBA;
        public static AbilityTreeDef WN_MangekyouME;
        public static AbilityTreeDef WN_MangekyouNA;
        public static AbilityTreeDef WN_MangekyouNI;
        public static AbilityTreeDef WN_MangekyouRA;
        public static AbilityTreeDef WN_MangekyouRS;
        public static AbilityTreeDef WN_MangekyouSA;
        public static AbilityTreeDef WN_MangekyouSE;
        public static AbilityTreeDef WN_MangekyouSN;
    }
}
