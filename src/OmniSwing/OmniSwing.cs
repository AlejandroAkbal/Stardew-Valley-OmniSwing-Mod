using System;
using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Tools;

namespace OmniSwing
{
    internal class OmniSwing
    {
        public static void AutoSwing()
        {
            Farmer player = Game1.player;

            MeleeWeapon currentTool = player.CurrentTool as MeleeWeapon;

            if (currentTool == null)
            {
                ModLogger.Debug("Current tool is not a melee weapon.");
                return;
            }

            Vector2 toolLocation = player.GetToolLocation(true);
            //int toolLocationX = (int)Math.Round(toolLocation.X);
            //int toolLocationY = (int)Math.Round(toolLocation.Y);

            ModLogger.Debug($"Swinging '{currentTool.BaseName}'");

            // --- Modifiers

            //currentTool.setFarmerAnimating(player);

            //currentTool.AnimationSpeedModifier = 0;

            // --- Swing mechanic

            // Works
            currentTool.doSwipe(currentTool.type, toolLocation, player.facingDirection, currentTool.speed, player);

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