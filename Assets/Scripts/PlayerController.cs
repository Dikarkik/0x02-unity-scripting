using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Vector3 forceDirection;
    Vector3 rotationDirection;

	// Start is called before the first frame update
	void Start() => rb = GetComponent<Rigidbody>();

	// Update is called once per frame
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
}
