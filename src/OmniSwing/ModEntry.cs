using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace OmniSwing
{
    public class ModEntry : Mod
    {
        private ModConfig Config;

        public override void Entry(IModHelper helper)
        {
            this.Config = this.Helper.ReadConfig<ModConfig>();

            ModLogger.Initialize(Monitor);
            OmniSwing.Initialize(Config);

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