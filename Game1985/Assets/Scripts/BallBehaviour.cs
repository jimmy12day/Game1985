using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
