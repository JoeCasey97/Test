using UnrealBuildTool;

public class MashNDashClientTarget : TargetRules
{
	public MashNDashClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MashNDash");
	}
}
