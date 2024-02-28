using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticVar : MonoBehaviour
{
    private int score_val;
    public int score{
        get { return score_val; }
        set { score_val = value; }
    }
}
