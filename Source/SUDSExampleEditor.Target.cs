

using UnrealBuildTool;
using System.Collections.Generic;

public class SUDSExampleEditorTarget : TargetRules
{
	public SUDSExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "SUDSExample" } );
	}
}
