using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        playerRb.velocity = Vector3.forward;
    }
}
