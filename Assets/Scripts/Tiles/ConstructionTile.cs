using NUnit.Framework;
using Towers;
using UnityEditor.SearchService;
using UnityEngine;

namespace Tiles
{
    public class ConstructionTile : Tile
    {
        [HideInInspector] public bool HasTower;

        protected override void OnTowerPlacement(Tower tower)
        {
            HasTower = true;
        }
    }
}
