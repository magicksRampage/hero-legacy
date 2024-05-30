using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public float timeToLive = 1.0f;

    private float timeAlive = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeAlive >= timeToLive) {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        timeAlive += Time.fixedDeltaTime;
    }
}
