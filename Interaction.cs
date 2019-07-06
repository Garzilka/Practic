using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other){
        print(other.gameObject.name);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
