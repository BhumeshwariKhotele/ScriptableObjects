using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cube;
    public int rows, columns;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
               GameObject instance= Instantiate(cube);
                Vector3 pos = new Vector3(x, Mathf.PerlinNoise(x * 0.2f, y * 0.2f) * 3, y);
                instance.transform.position = pos;
            }
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
