using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour {

    bool inside = false;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag=="Ladders")
        {
            inside = !inside;

            Debug.Log("boop");
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag=="Ladders")
        {
            inside = !inside;
            Debug.Log("boop");
        }
    }
    void Update ()
    {
        if (Input.GetKey("w") && inside==true)
        {
            transform.Translate(Vector3.up * 20 * Time.deltaTime);
        }
    }
}
