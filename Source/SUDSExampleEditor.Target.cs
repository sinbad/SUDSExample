

using UnrealBuildTool;
using System.Collections.Generic;

public class SUDSExampleEditorTarget : TargetRules
{
	public SUDSExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;

		ExtraModuleNames.AddRange( new string[] { "SUDSExample" } );
	}
}
