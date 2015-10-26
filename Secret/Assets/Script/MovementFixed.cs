using UnityEngine;
using System.Collections;

public class MovementFixed : MonoBehaviour {

	Animator anim;
	public float speed = 0.5f;



		void start(){
		anim =gameObject.GetComponent<Animator>();
	}



	void Update ()
	{
		// anim.Setfloats are the isolated errors where its coming from.
		// anim.SetFloat ("Speed", Mathf.Abs (speed));
		movement();
	}


void movement()
{
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.position += Vector3.left * speed * Time.deltaTime;
			// anim.SetFloat ("Speed", speed);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.UpArrow))
			{
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
		
	
	
}

}
