using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pparty : MonoBehaviour
{
    public SpriteRenderer cr;

    bool cambiarcolor = true, cplayer = true;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("color", 2.0f, 0.3f);
        color();
    }

    // Update is called once per frame
    void Update()
    { 
        if(cambiarcolor)
        {
            Invoke("color",3f);
            Debug.Log("cambio de color");
            cambiarcolor=false;
        }
    }
    void color()
    {
        if (cplayer)
        {
            cr.color = new Color(Random.Range(0,2),Random.Range(0,2),Random.Range(0,2),1);
            cambiarcolor=true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("nooooooooo");
        cplayer=false;
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        Debug.Log("siiiiiiiii");
        cplayer=true;
        cambiarcolor=true;
    }
}
