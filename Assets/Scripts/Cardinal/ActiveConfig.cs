using UnityEngine;

public class ActiveConfig : MonoBehaviour {
    public static float genDist => config.genDist;
    public static float genVariance => config.genVariance;
    public static float genProb => config.genProb;
    public static int pathWidth => config.pathWidth;
    public static int pathStepWidth => config.pathStepWidth;
    public static int lineWidth => config.lineWidth;

    public static float acceleration => config.acceleration;
    public static float speed => config.speed;
    public static float difficultyMultiplier => config.difficultyMultiplier;

    public static GameConfig config;
}