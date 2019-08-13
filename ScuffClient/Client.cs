﻿using System;
using VRLoader.Attributes;
using VRLoader.Modules;
using ScuffClient.Patches;
using ScuffClient.Menu;
using UnityEngine.UI;
using UnityEngine;
using ScuffClient.Misc;
using VRCSDK2;

namespace ScuffClient
{
    [ModuleInfo("ScuffClient", "?", "Nova")]
    public class Client : VRModule 
    {
        public void Start()
        {
            base.gameObject.AddComponent<AntiMenu>();
            base.gameObject.AddComponent<TargetPlayerMenu>();
            base.gameObject.AddComponent<Cheats>();
            base.gameObject.AddComponent<SpyCamera>();
            Patcher.CreatePatches();
        }
        public void Update()
        {
            if (Event.current.shift && Input.GetKeyDown(KeyCode.P))
                Exploits.DropPortal();

            if (Event.current.shift && Input.GetKeyDown(KeyCode.L))
                Exploits.TriggerIndexOutOfRange();
        }
    }
}
