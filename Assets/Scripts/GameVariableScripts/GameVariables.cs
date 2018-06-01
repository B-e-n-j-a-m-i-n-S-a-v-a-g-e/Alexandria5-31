using System;

public static class GameVariables {

	public static int Rows = Serialization.boardConfig.GENERAL_NumRows;
	public static int Columns = Serialization.boardConfig.GENERAL_NumColumns;

	public static float AnimationDuration = 0.2f;
	public static float MoveAnimationDuration = 0.05f;

	public static float ExplosionAnimationDuration = 0.3f;

	public static float WaitBeforePotentialMatchesCheck = 2.0f;
	public static float OpacityAnimationDelay = 0.05f;

	public static int MinimumMatches = 3;
	public static int MinimumMatchesForBonus = 4;

	public static int MatchScore = 100;
	public static int SubsequelMatchScore = 1000;
}
