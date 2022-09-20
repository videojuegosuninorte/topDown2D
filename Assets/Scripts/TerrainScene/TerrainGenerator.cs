using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    int[,] layout = new int[,] { { 1,0,0 }, { 0, 1, 0 }, { 0, 0, 1 } };
    public GameObject grassPrefab;
    public GameObject dirtPrefab;
    private int width = 3;
    private int height = 3;




    void Start()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (layout[i,j] == 1)
                {
                    Debug.Log("grass on "+ i+ " "+ j);
                    Instantiate(grassPrefab, new Vector3(j, i, 0), Quaternion.identity);
                } else
                {
                    Debug.Log("dirt on " + i + " " + j);
                    Instantiate(dirtPrefab, new Vector3(j, i, 0), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
