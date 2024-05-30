using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrallaxNubes : MonoBehaviour
{
    public GameObject reference;

    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reference.transform.position.x < Camera.main.transform.position.x-20)
        {
            transform.position = new Vector3(end.position.x, transform.position.y,
                transform.position.z);
        }

        //transform.position += new Vector3(-0.86f*Time.deltaTime, 0, 0);
        transform.position += new Vector3(-2*Time.deltaTime, 0, 0);

    }
}
