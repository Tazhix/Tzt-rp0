using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float foreWardForce = 2000f;
    public float sideWaysForece = 500f;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb.AddForce(0,200,200);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, foreWardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForece * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForece * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
			
		}
    }
}
