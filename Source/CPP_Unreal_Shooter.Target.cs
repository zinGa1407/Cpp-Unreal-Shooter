// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CPP_Unreal_ShooterTarget : TargetRules
{
	public CPP_Unreal_ShooterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "CPP_Unreal_Shooter" } );
	}
}
