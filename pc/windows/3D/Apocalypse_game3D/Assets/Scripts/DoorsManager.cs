using UnityEngine;

public class DoorsManager : MonoBehaviour {

    public GameObject Laboratory_door;

    public float movespeed = 1000f,turnSpeed = 50f;



    void Update()

    {

     if (Input.GetKey("u"))

     {

         Laboratory_door.transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime);

    }

    if (Input.GetKey("i"))

    { 

        Laboratory_door.transform.Rotate(Vector3.up,-turnSpeed * Time.deltaTime);

    }
 
    }



}
