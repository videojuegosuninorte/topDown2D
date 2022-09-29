using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    [SerializeField] private Cell CellPrefab;
    [SerializeField] private Player PlayerPrefab;
    [SerializeField] private GameObject TerrainParant;
    [SerializeField] private PowerSource PowerSourcePrefab;
    private Grid grid;
    private Player player;
    [SerializeField]
    private float moveSpeed = 2f;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        grid = new Grid(11, 20, 1, CellPrefab, TerrainParant);

        player = Instantiate(PlayerPrefab, new Vector2(0, 0), Quaternion.identity);

        Instantiate(PowerSourcePrefab, new Vector2(5, 19), Quaternion.identity);

        List<Cell> path = PathManager.Instance.FindPath(grid, (int)player.GetPosition.x, (int)player.GetPosition.y, 5, 19);

        player.SetPath(path);
    }

    public void CellMouseClick(int x, int y)
    {
        Debug.Log("CellMouseClick " + x + " " + y);
        //List<Cell> path = PathManager.Instance.FindPath(grid, (int)player.GetPosition.x, (int)player.GetPosition.y, x, y);

        //player.SetPath(path);
    }

}
