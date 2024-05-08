using UnrealBuildTool;

public class Ranch_Wrangler3DTarget : TargetRules
{
	public Ranch_Wrangler3DTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Ranch_Wrangler3D");
	}
}
