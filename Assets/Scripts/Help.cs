using UnityEngine;

public class Help {
    public static float Clamp(float low, float v, float high) {
        return Mathf.Min(high, Mathf.Max(low, v));
    }
}