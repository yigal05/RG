using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_camisa : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX=false;
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           gameObject.GetComponent<SpriteRenderer>().flipX=true;
        } 
    }
}
