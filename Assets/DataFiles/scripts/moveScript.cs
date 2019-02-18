using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float xvalue,yvalue,zvalue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xvalue,yvalue,zvalue)*Time.deltaTime);
    }
}
