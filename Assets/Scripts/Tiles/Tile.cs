using Towers;
using UnityEngine;

namespace Tiles
{
    /// <summary>
    /// Abstract class for tiles.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public abstract class Tile : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Tower tower))
                OnTowerPlacement(tower);
        }
        /// <summary>
        /// Method for doing logic when the tower is placed.
        /// </summary>
        /// <param name="tower">
        /// Tower placed on the tile
        /// </param>
        protected virtual void OnTowerPlacement(Tower tower)
        {
        
        }
    }
}