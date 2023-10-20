using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Data/GameConfig")]
public class GameConfig : ScriptableObject {
    public float genDist;
    public float genVariance;
    public float genProb;
    public int pathWidth;
    public int pathStepWidth;
    public int lineWidth;

    public float acceleration;
    public float speed;
    public int difficultyMultiplier;
}