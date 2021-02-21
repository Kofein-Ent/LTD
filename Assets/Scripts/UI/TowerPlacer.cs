using Towers;
using UnityEngine;

namespace UI
{
    public class TowerPlacer : MonoBehaviour
    {
        private Vector3 _createPosition;

        public void GetPosition(Vector3 position) => 
            _createPosition = position;
        
        public void PlaceTower(Tower tempTower)
        {
            Tower tower = Instantiate(tempTower, _createPosition, Quaternion.identity);
            tower.gameObject.SetActive(true);
        }

    }
}