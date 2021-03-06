using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject block;
    public uint Width = 3;
    public uint Height = 3;
    public uint Depth = 3;

    public bool b_Test = false;

    // Start is called before the first frame update
    void Start()
    {
        /*for (uint x = 0; x < Width; ++x)
        {
            for (uint y = 0; y < Height; ++y)
            {
                for (uint z = 0; z < Depth; ++z)
                {
                    if (x > 0 && x < Width - 1 &&
                        y > 0 && y < Height - 1 &&
                        z > 0 && z < Depth - 1)
                        continue;

                    Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }*/
    }

    public void CreateCubes(uint w, uint h, uint d)
    {
        for (uint x = 0; x < w; ++x)
        {
            for (uint y = 0; y < h; ++y)
            {
                for (uint z = 0; z < d; ++z)
                {
                    if (x > 0 && x < w - 1 &&
                        y > 0 && y < h - 1 &&
                        z > 0 && z < d - 1)
                        continue;

                    Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }
    }

}
