using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;

    // Use this for initialization
    void Start()
    {
        if (target == null)
        {
            Debug.LogError("Camera Target is not assigned!");
        }
        offset = this.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
