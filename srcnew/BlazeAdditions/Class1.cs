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
        }
    }
    [DefOf]
    public static class BlazeDefOf
    {
        public static AbilityTreeDef WN_MangekyouIZ;
    }

    //public class BlazeNarutoAdditionsMod : Mod
    //{
    //    public BlazeNarutoAdditionsMod(ModContentPack content) : base(content)
    //    {
    //        WN_Utils.mangekyouTrees.Add(BlazeDefOf.WN_MangekyouIZ);
    //    }
    //}

    //[DefOf]
    //public static class BlazeDefOf
    //{
    //    public static AbilityTreeDef WN_MangekyouIZ;
    //}
}
