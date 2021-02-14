using Enemies;
using UnityEngine;

namespace Tiles
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<Enemy>(out _))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
