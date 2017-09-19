using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class LevelController : MonoBehaviour
    {
        [SerializeField]
        private Spawner _enemySpawner;
        [SerializeField]
        private GameObject[] _enemyMovementTargets;

        protected void Awake()
        {
            if(_enemySpawner == null)
            {
                Debug.Log("No reference to an enemy Spawner.");
                _enemySpawner = GetComponentInChildren<Spawner>();
            }
            SpawnEnemyUnit();
        }

        private EnemySpaceship SpawnEnemyUnit()
        {
            GameObject spawnedEnemyObject = _enemySpawner.Spawn();
            EnemySpaceship enemyShip = spawnedEnemyObject.GetComponent<EnemySpaceship>();
            if (enemyShip != null)
            {
                enemyShip.setMovementTargets(_enemyMovementTargets);
            }
            return enemyShip;
        }
    }
}
