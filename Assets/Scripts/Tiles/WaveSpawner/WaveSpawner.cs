using System.Collections;
using UnityEngine;

namespace Tiles.WaveSpawner
{
    public class WaveSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _parentTransform;
        [SerializeField] private Wave[] _waves;
        [SerializeField] private float _waveDelay;

        private void Start()
        {
            StartCoroutine(SpawnWave());
        }

        private IEnumerator SpawnWave()
        {
            foreach (Wave wave in _waves)
            {
                StartCoroutine(SpawnRoutine(wave));
                yield return new WaitForSeconds(_waveDelay);
            }
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