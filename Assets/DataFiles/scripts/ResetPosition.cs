using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalPos;
    void Start()
    {
        originalPos=transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide){
        if(collide.gameObject.CompareTag("SHIPWALL")){
            transform.localPosition=originalPos;
        }
        else if(collide.gameObject.CompareTag("CLOUDWALL")){
            transform.localPosition=originalPos;
        }
        else if(collide.gameObject.CompareTag("AEROPLANEWALL")){
            transform.localPosition=originalPos;
        }
    }
    
}
