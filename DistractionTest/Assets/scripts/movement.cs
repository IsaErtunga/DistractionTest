using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float speed = 50f;
	public Transform tf;
	public Transform cameraTF;

	private Vector3 playerMove;
	private Vector3 input;

	// Start is called before the first frame update
	void Start()
	{
		playerMove = new Vector3(0, 0, 0);
		cameraTF.rotation = tf.rotation;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		tf.rotation = cameraTF.rotation;

        //tf.rotation.y = cameraTF.rotation.y;

		if (input != playerMove)
		{
			tf.Translate(input * speed * Time.deltaTime);
		}

	}
}



