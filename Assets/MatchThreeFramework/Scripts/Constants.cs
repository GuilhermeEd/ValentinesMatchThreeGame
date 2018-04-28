﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Constants
{
  public static readonly int Rows = 12;
  public static readonly int Columns = 8;
  public static readonly float AnimationDuration = 0.2f;

  public static readonly float MoveAnimationMinDuration = 0.075f;

  public static readonly float ExplosionDuration = 0.3f;

  public static readonly float WaitBeforePotentialMatchesCheck = 3f;
  public static readonly float OpacityAnimationFrameDelay = 0.05f;

  public static readonly int MinimumMatches = 3;
  public static readonly int MinimumMatchesForBonus = 4;

  public static readonly int Match3Score = 60;
  public static readonly int SubsequentMatchScore = 120;

  public static readonly int levelUpScore = 250;

  public static readonly int[] scoreNeededToLevel = {
    0,
    500,
    1000,
    1500,
    3000,
    7000,
    9000,
    13000,
    18000,
    24000,
    30000,
    };

}



