using System;
using Enemies;
using UnityEngine;

namespace WaveSpawner
{
    [Serializable]
    public struct Wave
    {
        public EnemyAmountPair[] EnemyAmountPairs;
        [Range(0, 2f)] public float SpawnDelay;
    }

    [Serializable]
    public struct EnemyAmountPair
    {
        public GameObject EnemyTemplate;
        public int Amount;
    }
}