using UnrealBuildTool;

public class MashNDashEditorTarget : TargetRules
{
	public MashNDashEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MashNDash");
	}
}
