using UnrealBuildTool;

public class Ranch_Wrangler3DServerTarget : TargetRules
{
	public Ranch_Wrangler3DServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Ranch_Wrangler3D");
	}
}
