using UnityEditor;

public class BuildScript 
{
    [MenuItem("Custom Utilities/Build WebGL")]
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" }; 
        string pathToDeploy = "builds/WebGLversion/";       

        BuildPipeline.BuildPlayer(defaultScene, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
        
    }

    [MenuItem("Custom Utilities/Build Asset Bundle StandaloneLinux64")]
    static void PerformAssetBundleBuild()
    {
        BuildPipeline.BuildAssetBundles("../AssetBundles/", BuildAssetBundleOptions.ChunkBasedCompression,
            BuildTarget.StandaloneLinux64);
    }
}
