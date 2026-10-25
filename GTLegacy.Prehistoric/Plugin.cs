using BepInEx;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace GTLegacy.Prehistoric
{
    [BepInPlugin("Instel.GTLegacy.Prehistoric", "GTLegacy Prehistoric", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            new Harmony("Instel.GTLegacy.Prehistoric").PatchAll();
        }
    }

    [HarmonyPatch(typeof(PhotonNetworkController), "Start")]
    static class MainPatch
    {
        static void Prefix()
        {
            PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion = Application.version;
            PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime = "fdd3a39b-0376-4904-8c3e-db878d7c908f";
            PhotonNetwork.PhotonServerSettings.AppSettings.AppIdVoice = "7c868eda-6bea-47e4-8922-4c2dab1057e2";
        }
    }
}
