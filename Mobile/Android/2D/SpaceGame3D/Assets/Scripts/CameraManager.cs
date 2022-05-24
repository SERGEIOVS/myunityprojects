using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject MyCamera;

    public float movespeed = 1000f,turnSpeed = 50f;



    void Update()

    {

     if (Input.GetKey("t"))

     {

         MyCamera.transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime);

    }

    if (Input.GetKey("y"))

    { 

        MyCamera.transform.Rotate(Vector3.up,-turnSpeed * Time.deltaTime);

    }
 
    }



}
