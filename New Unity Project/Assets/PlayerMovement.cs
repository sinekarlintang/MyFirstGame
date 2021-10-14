using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    public float upForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * sidewaysForce;
        float v = Input.GetAxis("Vertical") * upForce;

        transform.Translate(h, v, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(h, 0, 0), ForceMode.Impulse);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-h, 0, 0), ForceMode.Impulse);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0, v, 0), ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }   
}
