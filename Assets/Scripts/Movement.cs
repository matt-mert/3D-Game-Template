using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 100.0f;

    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        playerRb.velocity = Vector3.forward * playerSpeed * Time.fixedDeltaTime;
    }
}
