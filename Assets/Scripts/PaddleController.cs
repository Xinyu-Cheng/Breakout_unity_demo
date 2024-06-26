using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D _myRb;
    private Vector2 _direction;
    public float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        _myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            _direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            _direction = Vector2.right;
        }
        else {
            _direction = Vector2.zero;
        }
    }

    void FixedUpdate() {
        if (_direction == Vector2.zero) {
            return;
        }
        _myRb.AddForce(_direction * speed);
    }

}
