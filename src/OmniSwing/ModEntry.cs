using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace OmniSwing
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            ModLogger.Initialize(Monitor);

            helper.Events.Input.ButtonsChanged += this.OnButtonsChanged;
        }

        private void OnButtonsChanged(object sender, ButtonsChangedEventArgs e)
        {
            if (!Context.IsPlayerFree)
                return;

            foreach (SButton button in e.Held)
            {
                if (!button.IsUseToolButton())
                    return;

                //ModLogger.Debug($"OnButtonsChanged called with '{button}'.");

                OmniSwing.AutoSwing();
            }
        }
    }
}