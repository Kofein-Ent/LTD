using System.Collections;
using UnityEngine;
using WaveSpawner;

namespace Tiles.WaveSpawner
{
    public class WaveSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _parentTransform;
        [SerializeField] private Wave[] _waves;
        [SerializeField] private float _waveDelay;
        
        private int _currentWave;

        private void Start()
        {
            SpawnWave();
        }

        private void SpawnWave()
        {
            Wave wave = _waves[_currentWave++];

            StartCoroutine(SpawnRoutine(wave));
        }
        private IEnumerator SpawnRoutine(Wave wave)
        {
            foreach (EnemyAmountPair pair in wave.EnemyAmountPairs)
            {
                for (int i = 0; i < pair.Amount; i++)
                {
                    GameObject enemy = Instantiate(pair.EnemyTemplate, transform.position, Quaternion.identity, _parentTransform);
                    enemy.SetActive(true);
                    yield return new WaitForSeconds(wave.SpawnDelay);
                }
            }

        }
    }
}