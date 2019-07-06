using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationSystem : MonoBehaviour
{
    
    public float    minX,   minZ;
    public float    maxX,   maxZ;
    private float    X = 5,      Z = 5;
    private Vector3 Point;
    private Vector3 Position;
    private NavMeshAgent agent;
    
    public void newPoint()
    {
        X = Random.Range(minX, maxX); // позиция
        Z = Random.Range(minZ, maxZ); // позиция 
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        newPoint();
        Point.x = X;
        Point.z = Z;
    }
    float getDistance() //Дистанция от персонажа до точки
    {
        Position = agent.transform.position;
        float dis = Mathf.Sqrt((X - agent.transform.position.x) +
                               (Z - agent.transform.position.z));
        return (dis);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Point);    //Следовать до точки
        if(getDistance()<0.5)           //Если врадиусе точки
        {
            newPoint();                 //Новая точка
            Debug.Log("newPoint");
            Point.x = X;
            Point.z = Z;
        }
    }
}
