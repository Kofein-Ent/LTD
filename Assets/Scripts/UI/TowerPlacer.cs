using Towers;
using UnityEngine;

namespace UI
{
    public class TowerPlacer : MonoBehaviour
    {
        private Vector3 _createPosition;
        private Tower _tower;
        
        public void GetPosition(Vector3 position) => 
            _createPosition = position;
        public void GetTower(Tower tower) =>
            _tower = tower;
    }
}