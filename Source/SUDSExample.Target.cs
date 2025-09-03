

using UnrealBuildTool;
using System.Collections.Generic;

public class SUDSExampleTarget : TargetRules
{
	public SUDSExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "SUDSExample" } );
		
		if (!bBuildAllModules)  
		{  
			NativePointerMemberBehaviorOverride = PointerMemberBehavior.Disallow;  
		}
	}
}
