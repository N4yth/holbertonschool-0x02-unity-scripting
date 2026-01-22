using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("speed of the player")]
    [SerializeField]
    public float speed;

    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
