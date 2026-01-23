using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score = 0;

    public int health = 5;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup")) 
        {
            score += 1;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Trap"))
        {
            health -= 1;
            Debug.Log($"Health: {health}");
        }
        
    }
}
