using System.Collections;
using UnityEngine;

namespace Enemies
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] private Transform[] _waypoints;
        [SerializeField] [Range(0f, 20f)] protected float Speed;
        [SerializeField] protected float Health;

        private void OnEnable() => 
            StartCoroutine(MoveRoutine());
        
        /// <summary>
        /// Invokes every frame while enemy is alive.
        /// </summary>
        protected virtual void EnemyUpdate()
        {
            
        }
        private IEnumerator MoveRoutine()
        {
            foreach (Transform t in _waypoints)
            {
                while (Vector2.Distance(transform.position, t.position) > 0)
                {
                    transform.position = Vector2.MoveTowards(transform.position, t.position,
                        Speed * Time.deltaTime);
                    EnemyUpdate();
                    yield return null;
                }
            }
        }
    }
}