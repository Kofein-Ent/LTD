using System;
using UnityEngine;

namespace UI
{
    public class UIOpener : MonoBehaviour
    {
        public static bool IsPressed;
        
        [SerializeField] private GameObject _UIPanel;

        private TowerPlacer _towerPlacer;

        private void Awake() => 
            _towerPlacer = _UIPanel.GetComponent<TowerPlacer>();
        private void OnMouseDown()
        {
            IsPressed = true;
            if (!_UIPanel.activeSelf)
                _UIPanel.SetActive(true);

            _towerPlacer.GetPosition(transform.position);
        }
    }
}
