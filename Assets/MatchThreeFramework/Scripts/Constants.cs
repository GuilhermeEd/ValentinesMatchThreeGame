using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Constants {
  public static readonly int Rows = 12;
  public static readonly int Columns = 8;
  public static readonly float AnimationDuration = 0.2f;

  public static readonly float MoveAnimationMinDuration = 0.075f;

  public static readonly float ExplosionDuration = 0.3f;

  public static readonly float WaitBeforePotentialMatchesCheck = 1.5f;
  public static readonly float OpacityAnimationFrameDelay = 0.05f;

  public static readonly int MinimumMatches = 3;
  public static readonly int MinimumMatchesForBonus = 4;

  public static readonly int Match3Score = 60;
  public static readonly int SubsequentMatchScore = 120;

  public static readonly int[] scoreNeededToLevel = {
    0,
    25000,
    20000,
    12000,
    6500,
    4000,
  };

  public static readonly string[] sentences = {
    "Cinco anos se passaram desde então",
    "e nem um dia sequer conseguimos ficar sem o outro",
    "Fosse em crise ou alegria, o amor sempre crescia",
    "Aos poucos percebi que você é a única com quem posso ser feliz",
    "Sem querer me apaixonei a cada dia",
    "E como amei me apaixonar",
    "Porque você é a minha única e eterna namorada, minha melhor amiga e esposa",
    "O melhor que a vida tem a oferecer",
    "Agora estamos prontos para novas aventuras",
    "Que continuemos buscando nossos sonhos",
    "Juntos",
    "Pode ser que passemos por dificuldades durante nossa jornada",
    "Mas a dificuldade também nos ensinou a amar de verdade",
    "E aconteça o que acontecer, tenha certeza de uma coisa",
    "Sempre te amarei",
    "A lição mais importante já foi aprendida",
    "Quando se ama de verdade, o amor sempre vence",
    "E desde que tenhamos um ao outro, haja o que houver, sempre poderemos ...",
  };

}