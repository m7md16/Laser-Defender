using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Wave config", fileName ="New Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenEnemySpawns = 1f;
    [SerializeField] float spawnTimerVariance = 0f;
    [SerializeField] float minimumSpownTime = 0.2f;

    public int GetEnemyCount(){
        return enemyPrefabs.Count;
    }
    public GameObject GetEnemyPrefab(int index){
        return enemyPrefabs[index];
    }
    public Transform GetStartingWayPoint(){
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWayPoints(){
        List<Transform> waypoints = new List<Transform>();
        foreach( Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }
    public float GetMoveSpeed(){
        return moveSpeed;
    }

    public float GetRandomSpawnTime(){
        float spawnTime = Random.Range(timeBetweenEnemySpawns - spawnTimerVariance, timeBetweenEnemySpawns + spawnTimerVariance);
        return Mathf.Clamp(spawnTime, minimumSpownTime, float.MaxValue);
    }
   
}
