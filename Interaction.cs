using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Interaction : MonoBehaviour
{
    private NavigationSystem NS; 
    // Start is called before the first frame update
    void Start()
    {
        NS = GetComponent<NavigationSystem>();
    }
    void OnTriggerEnter(Collision other)
    {
        print(other.gameObject.name);
        Vector3 Pos = other.transform.position;
        NS.SetPoint(Pos.x, Pos.z);
        NS.Stop = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
