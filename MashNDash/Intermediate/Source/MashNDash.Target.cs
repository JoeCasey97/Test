using UnrealBuildTool;

public class MashNDashTarget : TargetRules
{
	public MashNDashTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MashNDash");
	}
}
