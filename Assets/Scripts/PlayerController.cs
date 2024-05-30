using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MovingObject
{

    Camera cam;
    private Vector2 currentHeading;

    public GameObject attackPrefab;

    // Start is called before the first frame update
    protected override void Start()
    {

        cam = Camera.main;

        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        currentMove = new Vector2(horizontal, vertical);

        Vector3 mousePosition = Input.mousePosition;
        Vector3 position = transform.position;


        mousePosition = cam.ScreenToWorldPoint(mousePosition);

        mousePosition.z = transform.position.z;

        Vector3 outDirection = mousePosition - transform.position;

        currentHeading = outDirection;
        currentHeading.Normalize();

        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Attack();
        }
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    private void Attack()
    {
        GameObject attackObject = Instantiate(attackPrefab, physics2D.position + currentHeading * 0.5f, Quaternion.identity);
    }


}
