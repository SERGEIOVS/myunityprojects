using UnityEngine;

public class playermanager : MonoBehaviour {

    public GameObject MyHero;
    public GameObject kitchen_knife;

    public float movespeed = 10f,turnSpeed = 50f;

    private AudioSource audio;

    float xRot;
    float yRot;
    float sensivity = 5f; 

    void Mouse()
    {
    
    xRot += Input.GetAxis("Mouse X") * sensivity;

    MyHero.transform.rotation = Quaternion.Euler(0f,xRot,0f);

    }

    void Update(){
    
    Mouse();
    

    audio = GetComponent<AudioSource>();
    

     if (Input.GetKey("w"))
     {
         MyHero.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
     }


        if (Input.GetKey("t"))
     {
         MyHero.transform.Translate(Vector3.up * movespeed * Time.deltaTime);
     }

    if (Input.GetKey("s"))
    

    {
        MyHero.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
    }


    if (Input.GetKey("x"))

    {
    
    kitchen_knife.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
    
    audio.Play();
    
    }
    
    if (Input.GetKey("c"))

    {
    kitchen_knife.transform.Translate(Vector3.left * -movespeed * Time.deltaTime);
    audio.Play();
    if (MyHero.transform.position.y < 10000)
    {
    print("Hi!");
    }
    
    }

    


    

    }

    void FixedUpdate()
    {

    }
}


/*

    if (Input.GetKey("r"))

    {
         MyHero.transform.Rotate(Vector3.left,turnSpeed * Time.deltaTime);
         
    }

    if (Input.GetKey("f"))
    { MyHero.transform.Rotate(Vector3.left,-turnSpeed * Time.deltaTime);
    
    }


    #MyHero.transform.Translate(Vector3.up * movespeed * Time.deltaTime);скрипт подъема по лестнице строго вверх
*/
    