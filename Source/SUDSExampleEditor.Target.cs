

using UnrealBuildTool;
using System.Collections.Generic;

public class SUDSExampleEditorTarget : TargetRules
{
	public SUDSExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "SUDSExample" } );
	}
}
