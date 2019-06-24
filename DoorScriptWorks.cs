using UnityEngine;
using System.Collections;

public class DoorScript1 : MonoBehaviour
{

    public float speed;
    public float angle;
    public Vector3 direction;

    // Use this for initialization
    void Start()
    {
        angle = transform.eulerAngles.y;
    }

    void Update()
    {
       if (Mathf.Round(transform.eulerAngles.y) != angle)
        { 
         transform.Rotate(direction * speed);
       }
        if (Input.GetKeyDown(KeyCode.C))   // VR Controller key for close 
        {
            angle = 90;
            direction = Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.O))  // VR Controller key for close 
        {
            angle = 0;
            direction = -Vector3.up;
        }

    }

}
