using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour
{
    [SerializeField] private float speedX = 1f;
    [SerializeField] private float speedY = 1f;
    [SerializeField] private GameObject goal;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.transform.position - transform.position;

        Vector3 aiPosition = transform.position;
        aiPosition.x += (direction.x * speedX * Time.deltaTime);
        aiPosition.y += (direction.y * speedY * Time.deltaTime);
        transform.position = aiPosition;
    }
}
