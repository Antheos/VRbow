using UnityEngine;
using System.Collections;

public class teleport_arrow : MonoBehaviour {

	public GameObject Player;
	public GameObject plateform;




	void OnCollisionEnter (Collision collision)
	{
		ContactPoint contact = collision.contacts [0];
		Vector3 pos = contact.point;

		Player = GameObject.Find ("[CameraRig]");

		if (collision.gameObject.tag == "teleportable_space") 
		
		{
			Player.transform.position = transform.position;
		}

		if (collision.gameObject.tag == "plateformable") 
		{
			
			{
				
				Instantiate (plateform, pos, collision.transform.rotation);

				Destroy (gameObject);
			}

		}

		if (collision.gameObject.tag == "plateform") 
		{
			Player.transform.position = gameObject.transform.position;
			Player.transform.rotation = collision.gameObject.transform.rotation;

			Destroy (gameObject);
		}

		else 
		{
			Destroy (gameObject);
		}



	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
