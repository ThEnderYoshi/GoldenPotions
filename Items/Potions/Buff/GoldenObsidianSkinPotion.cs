using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenObsidianSkinPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.ObsidianSkinPotion;

        public override void SafeDefaults()
        {
            Item.width = 30;
            Item.height = 34;

            Item.buffType = BuffID.ObsidianSkin;
            Item.buffTime = 12 * 60 * 60;
        }
    }
}
