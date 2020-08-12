using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform playerPos;
	public Vector3 offset; //Vector 3 stores 3 floats
						   // Update is called once per frame
	void Update()
	{
		transform.position = playerPos.position + offset;
	}
}
