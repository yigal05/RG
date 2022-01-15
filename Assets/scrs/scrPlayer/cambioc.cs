using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioc : MonoBehaviour
{
    public SpriteRenderer sp;
    public GameObject jugador,nomuere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jugador.gameObject.GetComponent<scr_movent>().poderc==true){

        if (Input.GetKeyDown("r"))
        {
        sp.color = new Color(1,0,0,1);
        }
        if (Input.GetKeyDown("e"))
        {
        sp.color = new Color(0,0,0,1);
        }
        if (Input.GetKeyDown("g"))
        {
        sp.color = new Color(0,1,0,1);
        }
        if (Input.GetKeyDown("b"))
        {
        sp.color = new Color(0,0,1,1);
        }
        if (Input.GetKey("r") && Input.GetKey("g"))
        {
        sp.color = new Color(1,1,0,1);
        }
        if (Input.GetKey("b") && Input.GetKey("r"))
        {
        sp.color = new Color(1,0,1,1);
        }
        if (Input.GetKey("g") && Input.GetKey("b"))
        {
        sp.color = new Color(0,1,1,1);
        }
        if (Input.GetKey("r") && Input.GetKey("g") && Input.GetKey("b"))
        {
        sp.color = new Color(1,1,1,1);
        }
        }
        }
}
