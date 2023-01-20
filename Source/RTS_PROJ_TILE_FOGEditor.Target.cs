// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RTS_PROJ_TILE_FOGEditorTarget : TargetRules
{
	public RTS_PROJ_TILE_FOGEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "RTS_PROJ_TILE_FOG" } );
	}
}
