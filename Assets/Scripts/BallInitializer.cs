using UnityEngine;

public class BallInitializer : MonoBehaviour
{
    private Rigidbody2D _myRb;
    public float speed = 500f;
    void Awake()
    {
        _myRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Invoke(nameof(SetRandomForce), 2f);
    }

    void SetRandomForce() {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1;

        _myRb.AddForce(force.normalized * speed);
    }


}
