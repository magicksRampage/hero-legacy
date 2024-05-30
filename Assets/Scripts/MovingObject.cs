using UnityEngine;

public class MovingObject : MonoBehaviour {
    public float speed = 5.0f;
    protected Rigidbody2D physics2D;

    protected Vector2 currentMove;

    protected virtual void Start() {
        physics2D = GetComponent<Rigidbody2D>();
        currentMove = new Vector2(0, 0);
    }

    private void Move(Vector2 move) {
        physics2D.MovePosition(physics2D.position + move * Time.fixedDeltaTime * speed);
    }

    protected virtual void FixedUpdate() {
        Move(currentMove);
    }
}