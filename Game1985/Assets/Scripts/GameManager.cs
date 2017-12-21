using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public Transform[] players;

    Rigidbody rb_Ball;
    float ballSpeed = 5f;
    Vector3 mousePosition;
    bool kickStart = false;


    // Use this for initialization
    void Start()
    {
        rb_Ball = ball.GetComponent<Rigidbody>();
        if (!rb_Ball)
        {
            Debug.Log("The Ball has not rigidbody compoenet,please attach it!");
        }
        Init();

    }

    // Update is called once per frame
    void Update()
    {
        SpecMousePosition();
    }

    void FixedUpdate()
    {
        if (kickStart)
        {
            MovePlayer();
        }
    }


    void BallMove()
    {
        Vector3.ClampMagnitude(rb_Ball.velocity, 10f);
        if (rb_Ball.velocity.x == 0 || rb_Ball.velocity.y == 0)
        {
            rb_Ball.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
    }

    private void ClampVelocity()
    {
    }

    void Init()
    {
        kickStart = true;
        if (rb_Ball)
            rb_Ball.AddForce(new Vector3(3, 3, 0) * ballSpeed, ForceMode.Impulse);
    }

    void SpecMousePosition()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
    }

    void MovePlayer()
    {
        if (players.Length == 0)
        {
            return;
        }
        foreach (Transform player in players)
        {
            player.position = Vector3.Lerp(player.position, new Vector3(player.position.x, mousePosition.y, player.position.z), Time.deltaTime * 8f);
        }
    }

    void ClampPlayer()
    {
        if (players.Length == 0)
        {
            return;
        }
        foreach (Transform player in players)
        {
            player.position = Vector3.Lerp(player.position, new Vector3(player.position.x, mousePosition.y, player.position.z), Time.deltaTime * 8f);
        }
    }
}
