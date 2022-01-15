using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class scr_movent : MonoBehaviour
{
    public Rigidbody2D rb; //el cuerpo de nuestro jugador.
    public float fsalto,vplayer,vfondo; //velocidad del salto,jugador y despalzamiento del fondo.
    public Animator ani,anicam; //animaciones del personaje y su camisa.
    public GameObject camara, camisa; // fondo,camara,objeto con el que se perdio,camisa.
    public bool poderc,podersaltar,respawn;
    public Vector3 vc;
    RaycastHit2D ray,roy;
    Vector3 offset= new Vector3(0.48f,0,0);
    public int puntos =0;

    // Start is called before the first frame update
    void Start()
    {
    respawn=false;
    camara.GetComponent<scamara>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {   
        roy=Physics2D.Raycast(gameObject.transform.position+offset,Vector2.down,1f);
        ray=Physics2D.Raycast(gameObject.transform.position-offset,Vector2.down,1f);
        if(ray.collider||roy.collider){
        podersaltar=true;
        Debug.DrawRay(gameObject.transform.position+offset,Vector2.down*1,Color.red);
        Debug.DrawRay(gameObject.transform.position-offset,Vector2.down*1,Color.red);
        }else{
        podersaltar=false;
        Debug.DrawRay(gameObject.transform.position+offset,Vector2.down*1,Color.green);
        Debug.DrawRay(gameObject.transform.position-offset,Vector2.down*1,Color.green);
        }
        ani.SetFloat("speed",0.0f);
        anicam.SetFloat("speed",0.0f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX=false;
            transform.position += new Vector3(vplayer*Time.deltaTime,0,0);
            ani.SetFloat("speed",0.4f);
            anicam.SetFloat("speed",0.4f);
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX=true;
            transform.position += new Vector3(-vplayer*Time.deltaTime,0,0);
            ani.SetFloat("speed",0.4f);
            anicam.SetFloat("speed",0.4f);
            GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
     
        }

        if (Input.GetKeyDown("space")&&podersaltar==true)
        {
            rb.AddForce(Vector2.up*fsalto,ForceMode2D.Impulse);

        }
        if (transform.position.y <= -7.6f) /*si la posicion y es menor a -7-6f significa que perdimos y estamos saliendo de la pantalla.
        haci que con lo siguiente lo llevamos al checkpoint,reactiamos la plataforma con la que perdimos y colocamos el fondo*/

        {
            GetComponent<SpriteRenderer>().flipX=false;
            if(respawn==false){
                camisa.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
            transform.position = new Vector3(-4.78f,-3.58f,-0.22f);
            camara.gameObject.transform.position=new Vector3(3.76f,1.37f,-10.32f);
            camisa.gameObject.GetComponent<SpriteRenderer>().flipX=false;
            }else{
                camisa.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
            transform.position = new Vector3(vc.x,vc.y,-0.22f);
            camara.gameObject.transform.position=new Vector3(transform.position.x+7,1.37f,-10.32f);
            camisa.gameObject.GetComponent<SpriteRenderer>().flipX=false;
            }
            
        }
        
    }
    private void OnCollisionStay2D(Collision2D other) {
      poderc=false;
      Debug.Log("entre");  
      if (other.gameObject.tag=="plataforma")//compara que estemos chocando con una plataforma mediante su tag.
      {
        if (other.gameObject.GetComponent<SpriteRenderer>().color==camisa.gameObject.GetComponent<SpriteRenderer>().color)
        {
           //Debug.Log("iguales"); //si los colores son iguales desabilita el trigger haciendo que podamos pararnos en esta plataforma.
           other.gameObject.GetComponent<BoxCollider2D>().isTrigger=false;
        }else{
           //Debug.Log("diferentes"); //si los colores no son iguales la plataforma se vuelve un trigger haciendonos caer.
           other.gameObject.GetComponent<BoxCollider2D>().isTrigger=true;
        }
      }

    }
    private void OnTriggerEnter2D(Collider2D other) //despues de perder reactiva la plataforma.
    {
    if(other.gameObject.tag!="invisible"){
    other.gameObject.GetComponent<BoxCollider2D>().isTrigger=false;   

    }}
    private void OnCollisionExit2D(Collision2D other) {
    poderc=true;
    Debug.Log("sali");
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name=="detector"){
            Debug.Log("activa camraa");
            camara.gameObject.GetComponent<scamara>().enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name=="detector"){
            Debug.Log("ya xncklansfklnsd");
            camara.gameObject.GetComponent<scamara>().enabled = false; }       
    }

}
