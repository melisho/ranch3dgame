using UnrealBuildTool;

public class Ranch_Wrangler3DEditorTarget : TargetRules
{
	public Ranch_Wrangler3DEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Ranch_Wrangler3D");
	}
}
