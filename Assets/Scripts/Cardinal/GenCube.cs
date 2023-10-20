﻿using System.Collections;
using UnityEngine;

public class GenCube : MonoBehaviour {
    public bool showPath;

    public GameObject refCube;
    public GameObject powerup;
    public GameObject[] cubes;

    public float genDelta = 1.0f;
    public float genVariance = 4.0f;
    public float genProb = 0.01f;
    public int pathWidth = 1;
    public int pathStepWidth = 1;
    public int lineWidth = 6;

    private int _pathX;

    private Rigidbody _body;

    private IEnumerator GenCubes() {
        while (true) {
            yield return new WaitForSecondsRealtime(genDelta);
            for (int x = -lineWidth; x <= lineWidth; ++x) {
                if (showPath && x == _pathX) {
                    Instantiate(refCube, new Vector3(x, 0.9f, 40.0f), Quaternion.identity);
                }

                if (Mathf.Abs(x - _pathX) <= pathWidth) {
                    if (Random.Range(0f, 10f) < genProb) {
                        Instantiate(
                            powerup,
                            new Vector3(x, 0.9f, 40.0f + Random.Range(-genVariance, genVariance)),
                            Quaternion.identity
                        );
                    }
                    continue;
                }

                int i = Mathf.RoundToInt(Random.Range(-0.5f, 2.5f));
                Instantiate(
                    cubes[i],
                    new Vector3(x, 0.9f, 40.0f + Random.Range(-genVariance, genVariance)),
                    Quaternion.identity
                );
            }

            if (_pathX == -lineWidth + 2) {
                _pathX += Mathf.RoundToInt(Random.Range(-0.5f, pathStepWidth + 0.5f));
            } else if (_pathX == lineWidth - 2) {
                _pathX += Mathf.RoundToInt(Random.Range(-pathStepWidth - 0.5f, 0.5f));
            } else {
                _pathX += Mathf.RoundToInt(Random.Range(-pathStepWidth - 0.5f, pathStepWidth + 0.5f));
            }
            // _pathX = Mathf.Clamp(_pathX, -lineWidth + 2, lineWidth - 2);
        }
    }

    private void Start() {
        StartCoroutine(GenCubes());
    }

    private void OnReset() {
        StopAllCoroutines();
        StartCoroutine(GenCubes());
    }
}