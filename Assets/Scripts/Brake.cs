using UnityEngine;

public class Brake : MonoBehaviour
{
    public Rigidbody rb;
    public SpriteRenderer spriteRenderer;

    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && rb.velocity.magnitude > 0.1f)
        {
            transform.position = new Vector3(rb.transform.position.x, 0.28f, rb.transform.position.z);
            spriteRenderer.enabled = true;
        }
        else
            spriteRenderer.enabled = false;
    }
}
