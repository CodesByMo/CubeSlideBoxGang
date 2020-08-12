using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidwaysForce = 500f;

	public float playerFell = -1f;
	// Update is called once per frame
	void FixedUpdate()
	// use FixedUpdate when working with physics (eg: rigidbody)
	{
		//Add a forward Force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))
		{
			rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < playerFell)
		{
			FindObjectOfType<Manager>().EndGame();
		}
	}
}
