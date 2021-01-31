using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewValley;
using StardewValley.Tools;

namespace OmniSwing
{
    public static class OmniSwing
    {
        private static readonly ModConfig Config = ModEntry.Config;

        private static readonly IReflectionHelper Reflection = ModEntry.Helper.Reflection;

        public static void AutoSwing()
        {
            Farmer player = Game1.player;

            MeleeWeapon currentTool = player.CurrentTool as MeleeWeapon;

            if (currentTool == null)
            {
                ModLogger.Trace("Current tool is not a melee weapon.");
                return;
            }

            if (Config.CheckIfToolIsScythe && currentTool.isScythe())
            {
                ModLogger.Trace("Current tool is a Scythe.");
                return;
            }

            Vector2 toolLocation = player.GetToolLocation(true);
            //int toolLocationX = (int)Math.Round(toolLocation.X);
            //int toolLocationY = (int)Math.Round(toolLocation.Y);

            ModLogger.Debug($"Swinging '{currentTool.BaseName}'.");

            // --- Modifiers

            //currentTool.setFarmerAnimating(player);

            //currentTool.AnimationSpeedModifier = 0;

            // --- Swing mechanic

            // Works and respects the game
            Reflection.GetMethod(player, "performFireTool").Invoke();

            // Works but turns tool invisible
            //currentTool.beginUsing(player.currentLocation, toolLocationX, toolLocationY, player);
            //currentTool.endUsing(player.currentLocation, player);

            // Doesn't do anything
            //currentTool.leftClick(player);

            // Doesn't do anything
            //currentTool.DoFunction(player.currentLocation, toolLocationX, toolLocationY, 1, player);
        }
    }
}