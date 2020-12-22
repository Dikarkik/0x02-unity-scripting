using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score = 0;

    // movement and rotation
    public float speed;
    Rigidbody rb;
    Vector3 forceDirection;
    Vector3 rotationDirection;

    void Start() => rb = GetComponent<Rigidbody>();

	void FixedUpdate()
    {
            // movement
            forceDirection.x = Input.GetAxis("Horizontal");
            forceDirection.z = Input.GetAxis("Vertical");
            rb.AddForce(forceDirection * speed * Time.deltaTime);

            // rotation
            rotationDirection.x = Input.GetAxis("Vertical");
            rotationDirection.z = -Input.GetAxis("Horizontal");
            transform.Rotate(rotationDirection * (speed * 3) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup"))
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log($"Score: {score}");
        }
    }
}
