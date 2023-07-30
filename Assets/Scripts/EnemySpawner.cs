using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigSO currentWave;
    void Start()
    {
        spawnEnemies();
    }
    public WaveConfigSO GetCurrentWave(){
        return currentWave;
    }

    private void spawnEnemies()
    {
        for (int i=0; i < currentWave.GetEnemyCount(); i++){
            Instantiate(currentWave.GetEnemyPrefab(i),
                        currentWave.GetStartingWayPoint().position,
                        Quaternion.identity,
                        transform);
        }
    }
}
