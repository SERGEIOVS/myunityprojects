using UnityEngine;

public class VehicleManager : MonoBehaviour {

    public GameObject Helicopter3;

    public float movespeed = 3f,turnSpeed = 40f;

    public int walk_distance = 1;

    void Update()
    
    {
        if(walk_distance > 0)
        {
            Helicopter3.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        }

        walk_distance +=1;

        if (walk_distance == 100)
        {movespeed = 0;}
        
    if (Input.GetKey("m"))
     {
         movespeed = 0f;
     }

    if (Input.GetKey("n"))
     {
         movespeed = 3f;
     }


     if (Input.GetKey("x"))
     {
         walk_distance = 0;
     }
        
    }

    void FixedUpdate()
    {

    }
    
    
    


    }
