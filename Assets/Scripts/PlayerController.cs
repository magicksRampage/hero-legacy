using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MovingObject
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        currentMove = new Vector2(horizontal, vertical);
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


}
