using System;
using Chipstix.ExampleBall;
using HarmonyLib;
using StationeersMods.Interface;
[StationeersMod("ExampleBall","ExampleBall [StationeersMods]","0.2.4657.21547.1")]
public class ExampleBall : ModBehaviour
{
    // private ConfigEntry<bool> configBool;
    
    public override void OnLoaded(ContentHandler contentHandler)
    {
        UnityEngine.Debug.Log("ExampleBall says: Hello World!");
        
        //Config example
        // configBool = Config.Bind("Input",
        //     "Boolean",
        //     true,
        //     "Boolean description");
        
        Harmony harmony = new Harmony("ExampleBall");
        PrefabPatch.prefabs = contentHandler.prefabs;
        harmony.PatchAll();
        UnityEngine.Debug.Log("ExampleBall Loaded with " + contentHandler.prefabs.Count + " prefab(s)");
    }
}
