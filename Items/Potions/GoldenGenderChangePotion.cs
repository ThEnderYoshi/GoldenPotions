using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions
{
    internal class GoldenGenderChangePotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.GenderChangePotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Changes your gender TWICE");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 38;
            Item.UseSound = SoundID.Item6;
        }

        //TODO: Gender change dust effects
    }
}
