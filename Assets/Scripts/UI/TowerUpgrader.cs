using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Towers;

public class TowerUpgrader : MonoBehaviour
{
    
    private Tower _tower;

    public void SetTower(Tower tower)
    {
        _tower = tower;
    }

    public void DeleteTower()
    {
        Destroy(_tower.gameObject);
    }
}
