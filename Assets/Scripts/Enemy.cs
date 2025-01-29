using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   public float distance;
   public Transform player;
   public NavMeshAgent nav;

    void Start()
    {
       
    }

    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.position);

        if (distance < 1) 
        {
            nav.destination = player.position;
        }
    }
}
