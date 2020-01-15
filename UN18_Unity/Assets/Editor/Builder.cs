using System.Linq;

using UnityEditor;

public class Builder 
{
    static void Build ()
    {
        var buildOpts = new BuildPlayerOptions()
        {
            options = BuildOptions.None,
            target = BuildTarget.iOS,
            targetGroup = BuildTargetGroup.iOS,
            scenes = EditorBuildSettings.scenes
                .Where(x => x.enabled)
                .Select(x => x.path)
                .ToArray(),
            locationPathName = @"P:\Builds\UN18_ios"
        };
        var buildReport = BuildPipeline.BuildPlayer(buildOpts);
    }
}

