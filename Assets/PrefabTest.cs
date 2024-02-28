using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PrefabTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Block");
        for (float z = 0.0f;z < 9.0f;z+=1.5f)
        {
            for (float x = -5.0f;x < 5.0f;x+=3.0f)
            {
                Instantiate(obj,new Vector3(x,1.5f,z),Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
