using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public float enemymovespeed = 3f,enemyturnSpeed = 40f;
    public GameObject hugemutant;
    public int enemywalk_distance = 1;



    void Update()
    
    {
        if(enemywalk_distance > 0)
        {
            hugemutant.transform.Translate(Vector3.left * enemymovespeed * Time.deltaTime);
        }

        enemywalk_distance +=1;

        if (enemywalk_distance == 100)
        {enemymovespeed = 0;}
        
    if (Input.GetKey("m"))
     {
         enemymovespeed = 0f;
     }

    if (Input.GetKey("n"))
     {
         enemymovespeed = 30f; 
     }


     if (Input.GetKey("z"))
     {
         enemywalk_distance = 0;
     }

    }

    void FixedUpdate()
    {

    }
    
    
    


    }
