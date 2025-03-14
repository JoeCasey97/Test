using UnrealBuildTool;

public class MashNDashServerTarget : TargetRules
{
	public MashNDashServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MashNDash");
	}
}
