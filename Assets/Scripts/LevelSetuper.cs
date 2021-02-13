using System.Collections;
using System.Threading;
using Tiles;
using UnityEngine;

public class LevelSetuper : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private float _offset;
    [Header("Tile Map")]
    [SerializeField] private int _rows;
    [SerializeField] private int _columns;
    [SerializeField] private GameObject[] _tiles;

    private void Awake() =>
        CreateTilemap();
    
    private void CreateTilemap()
    {
        Vector2 spawnPoint = _point.position;
        float startX = spawnPoint.x;
        for (int i = 0; i < _columns; i++)
        {
            for (int j = 0; j < _rows; j++)
            {
                GameObject tile = _tiles[j + _columns * i];
                if (tile != null) 
                    Instantiate(tile, spawnPoint, Quaternion.identity);
                spawnPoint.x += _offset;
            }
            spawnPoint.x = startX;
            spawnPoint.y -= _offset;
        }
    }
}
