using System;
using Tiles;
using UnityEngine;
namespace UI
{
    [RequireComponent(typeof(ConstructionTile))]
    public class UIPlaceOpener : MonoBehaviour
    {
        public static bool IsPressed;
        
        [SerializeField] private GameObject _UIPanel;
        
        private TowerUpgrader _towerUpgrader;
        private TowerPlacer _towerPlacer;

        private void Awake()
        {
     

            foreach (RectTransform child in _UIPanel.transform)
            {
                if (child.gameObject.TryGetComponent(out TowerUpgrader towerUpgrader))
                    _towerUpgrader = towerUpgrader;
                if (child.gameObject.TryGetComponent(out TowerPlacer towerPlacer))
                    _towerPlacer = towerPlacer;
            }
        }

        private void OnMouseDown()
        {
            IsPressed = true;
            if (!_UIPanel.activeSelf)
                Open();

        }

        private void Open()
        {
            _UIPanel.SetActive(true);
            _towerPlacer.GetPosition(transform.position);
            _towerPlacer.gameObject.SetActive(true);
            _towerUpgrader.gameObject.SetActive(false);
        }
    }
}
