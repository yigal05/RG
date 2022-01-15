using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatecolor : MonoBehaviour
{
    public SpriteRenderer cr;
    // Start is called before the first frame update
    void Start()
    {
        cr.color = new Color(Random.Range(0,2),Random.Range(0,2),Random.Range(0,2),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
