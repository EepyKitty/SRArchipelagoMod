﻿using SRML;
using SRML.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRArchipelagoMod
{

    [EnumHolder]
    public static class Ids
    {

    }

    public class Main : ModEntryPoint
    {
        // Called before GameContext.Awake
        // You want to register new things and enum values here, as well as do all your harmony patching
        public override void PreLoad()
        {
            HarmonyInstance.PatchAll();
        }


        // Called before GameContext.Start
        // Used for registering things that require a loaded gamecontext
        public override void Load()
        {
            
        }

        // Called after all mods Load's have been called
        // Used for editing existing assets in the game, not a registry step
        public override void PostLoad()
        {

        }

    }
}
