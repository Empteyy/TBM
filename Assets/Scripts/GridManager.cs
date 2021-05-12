using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float[,] Grid;
    int Vertical, Horizontal, Colums, Rows;
    public Camera mainCamera;
    public Sprite sprite;
    public GameObject player;
    

    void Start()
    {
        Vertical = (int)mainCamera.orthographicSize;
        Horizontal = Vertical * (Screen.width / Screen.height);
        Colums = Horizontal * 2;
        Rows = Vertical * 2;
        Grid = new float[Colums, Rows];
        for (int i = 0; i < Colums; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                Grid[i, j] = Random.Range(0f, 1f);
                SpawnTile(i, j, Grid[i, j]);
                
            }
        }

        SpawnPlayer();
    }

    void Update()
    {
        
    }

    void SpawnTile(int x, int y, float value)
    {
        GameObject g = new GameObject(x + " : " + y);
        g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
    }

    void SpawnPlayer()
    {
        player.transform.position = new Vector3(0.5f, 0.5f, 0.5f);
        Instantiate(player);
    }

    
}
