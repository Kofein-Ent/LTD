using System.Collections;
using UnityEngine;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] protected Transform[] _waypoints;
        [SerializeField] [Range(0f, 20f)] protected float _speed;
        [SerializeField] protected float _health;

        private void OnEnable() => 
            StartCoroutine(MoveRoutine());
        
        /// <summary>
        /// Invokes every frame while enemy is alive.
        /// </summary>
        protected virtual void OnMove()
        {
            
        }
        private IEnumerator MoveRoutine()
        {
            for (int i = 0; i < _waypoints.Length - 1; i++)
            {
                yield return new WaitForSecondsRealtime(2);
                while (Vector2.Distance(transform.position, _waypoints[i + 1].position) > .09f)
                {
                    transform.Translate((_waypoints[i + 1].position - _waypoints[i].position).normalized *
                                        (_speed * Time.deltaTime));
                    OnMove();
                    yield return null;
                }
                transform.position = _waypoints[i + 1].position;
            }
        }
    }
}