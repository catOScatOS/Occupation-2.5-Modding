using UnityEditor;
using UnityEngine;

public class BuildSceneBundle
{
    [MenuItem("Tools/Build Scene Bundle Mod")]
    static void BuildScene()
    {
        // Output Path
        string path = "Mods";
        if (!System.IO.Directory.Exists(path))
            System.IO.Directory.CreateDirectory(path);

        // Enter the path of included scene (Mod)
        string[] scenes = { "Assets/Scenes/Mods/MyMod/MyMod.unity" };

        // In the path "MyMod", enter the name you want to give this mod.
        BuildPipeline.BuildPlayer(
            scenes,
            path + "/MyMod.unity3d",
            BuildTarget.StandaloneWindows64,
            BuildOptions.BuildAdditionalStreamedScenes
        );
    }
}
