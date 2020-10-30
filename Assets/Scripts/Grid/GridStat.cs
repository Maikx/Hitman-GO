using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStat : MonoBehaviour
{
    public int visited = -1;
    public int x = 0;
    public int y = 0;

    private GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gm.level_1 == true)
        {
            if (x == 0 && y == 0 || x == 0 && y == 1 || x == 0 && y == 2)
            {
                gameObject.layer = 0;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}

