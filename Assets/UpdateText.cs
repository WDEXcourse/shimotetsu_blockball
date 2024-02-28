using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateText : MonoBehaviour
{
    

    public TextMeshProUGUI countText;
    // Update is called once per frame
    void Update()
    {
        StaticVar staticvar = new StaticVar(); //インスタンス化する
        
        countText.text = "Score:" + staticvar.score;
    }
}
