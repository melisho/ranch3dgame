using UnrealBuildTool;

public class Ranch_Wrangler3DClientTarget : TargetRules
{
	public Ranch_Wrangler3DClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Ranch_Wrangler3D");
	}
}
