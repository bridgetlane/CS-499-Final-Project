using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] enemies;
    public int amount;

    void spawnEnemy()
    {
        int index = Random.Range (0, SpawnPosition.indices.Count - 1);

        ArrayList indexSet = (ArrayList)SpawnPosition.indices[index];
        Vector3 spawnPoint;
        spawnPoint.x = (int)indexSet[0];
        spawnPoint.y = 0;
        spawnPoint.z = (int)indexSet[1];

        SpawnPosition.indices.RemoveAt (index);

        string name = Instantiate (enemyPrefab, spawnPoint, Quaternion.identity).name;

        SpawnPosition.spawnPositions [name] = spawnPoint;

        CancelInvoke ();
    }

    void Update ()
    {
        enemies = GameObject.FindGameObjectsWithTag ("Enemy");
        amount = enemies.Length;

        if (amount != 4)
            InvokeRepeating ("spawnEnemy", 5, 10);
    }
}
