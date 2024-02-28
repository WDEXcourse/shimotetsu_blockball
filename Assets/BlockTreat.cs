using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTreat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        // StaticVar staticvar = new StaticVar(); //インスタンス化する
        // staticvar.score += 1;

        Destroy(this.gameObject);
    }

}
  
