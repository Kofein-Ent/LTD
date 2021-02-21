using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using Towers;

public class UIUpgradeOpener : MonoBehaviour
{

    [SerializeField] private GameObject _UIPanel;
    
    public Tower Tower { get; private set; }

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
       UIPlaceOpener.IsPressed = true;
        if (!_UIPanel.activeSelf)
            Open();
            
    }

    private void Open()
    {
        _UIPanel.SetActive(true);
        _towerUpgrader.gameObject.SetActive(true);
        _towerUpgrader.SetTower(gameObject.GetComponent<Tower>());
        _towerPlacer.gameObject.SetActive(false);
    }
}
