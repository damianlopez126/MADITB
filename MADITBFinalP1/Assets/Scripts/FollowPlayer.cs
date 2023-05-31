using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= range)
        {
            FollowPlayer();
        }
    }

    public void FollowPlayer()
    {
        transform.position = Vector3.MoveToward(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
