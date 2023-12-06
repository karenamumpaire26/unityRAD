using UnityEngine;

public class PHYSICSCUBECONTROL : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForceAtPosition(Vector3.forward,
                transform.position - 0.5f * Vector3.forward + 0.5f * Vector3.up);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddExplosionForce(500, transform.position + Vector3.down, 2);
        }

    }
}