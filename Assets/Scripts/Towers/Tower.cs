using System;
using UnityEngine;
using Tiles;

namespace Towers
{
    /// <summary>
    /// Abstract class for towers.
    /// </summary>
    public abstract class Tower : MonoBehaviour
    {
        private void OnDestroy()
        {
            OnTowerDestroy();
        }

        protected virtual void OnTowerDestroy()
        {
            if (Physics.Raycast(transform.position,Vector3.back, out RaycastHit hit)) 
                hit.collider.GetComponent<ConstructionTile>().HasTower = false;
        }
        
    }
}