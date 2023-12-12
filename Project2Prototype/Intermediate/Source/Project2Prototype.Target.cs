using UnrealBuildTool;

public class Project2PrototypeTarget : TargetRules
{
	public Project2PrototypeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Project2Prototype");
	}
}
