using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MyAssets.Scripts
{
    public class Spawner: MonoBehaviour
    {
        [SerializeField] private List<GameObject> _spawnObjectsPrefab;
        
        [SerializeField] private List<Transform> _spawnPoints;

        private void Start()
        {
            foreach (Transform spawnPoint in _spawnPoints)
            {
                Instantiate(_spawnObjectsPrefab[Random.Range(0, _spawnObjectsPrefab.Count)], spawnPoint);
            }
        }
    }
}