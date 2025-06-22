using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class Useful
    {
        public static void AcceptTOSMod()
        {
            GameObject.Find("LegalAgreementCheck").SetActive(false);
            GameObject.Find("PrivateUIRoom").SetActive(false);
        }
    }
}
