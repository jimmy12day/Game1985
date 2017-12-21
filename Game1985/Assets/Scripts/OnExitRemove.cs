using UnityEngine;

public class OnExitRemove : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {

        other.transform.position = transform.position;
    }
}
