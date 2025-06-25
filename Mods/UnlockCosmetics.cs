using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GorillaNetworking;

namespace GorillaX.Mods
{
    internal class UnlockCosmetics
    {
        public static void UnlockCosmeticsMod()
        {
            if (CosmeticsController.instance == null) return;
            foreach(CosmeticsController.CosmeticItem cosmetic in CosmeticsController.instance.allCosmetics)
            {
                CosmeticsController.instance.unlockedCosmetics.Add(cosmetic);
                string itemName = cosmetic.itemName;
                CosmeticsController.instance.concatStringCosmeticsAllowed += itemName + ",";
            }
        }
    }
}
