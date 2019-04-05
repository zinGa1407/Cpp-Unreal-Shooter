// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CPP_Unreal_ShooterEditorTarget : TargetRules
{
	public CPP_Unreal_ShooterEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "CPP_Unreal_Shooter" } );
	}
}
