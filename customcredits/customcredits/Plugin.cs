using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace customcredits
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

            Utilla.Events.GameInitialized += OnGameInitialized;
        }



        void OnGameInitialized(object sender, EventArgs e)
        {
            Debug.Log("cloning objs");
            var CustomCreditboard = new GameObject();
            CustomCreditboard.name = "CustomCreditboard";
            var Stand = GameObject.Find("code of conduct");
            var screen = GameObject.Find("screen");
            var text = GameObject.Find("COC Text");
            Debug.Log("GOT ALL OBJS!");

            var standclone = GameObject.Instantiate(Stand);
            var screenclone = GameObject.Instantiate(screen);
            var textclone = GameObject.Instantiate(text);
            Debug.Log("Made all objects");
            standclone.transform.parent = CustomCreditboard.transform;
            screenclone.transform.parent = CustomCreditboard.transform;
            textclone.transform.parent = CustomCreditboard.transform;
            standclone.isStatic = false;
            screenclone.isStatic = false;
            textclone.isStatic = false;
            CustomCreditboard.transform.position = new Vector3(-63.4017f, 12.2899f, -81.6286f);
            CustomCreditboard.transform.rotation = Quaternion.Euler(0f, 282.9019f, 0f);
            Debug.Log("parented");
            Debug.Log("objs are all set up!");


        }

    }
}
