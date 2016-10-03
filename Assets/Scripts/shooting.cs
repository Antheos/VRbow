using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {


	public GameObject projectile;
	public GameObject projectile2;
	public float fireDelta = 0.5F;
	public float fireForce = 1000;
	private float nextFire = 0.5F;
	private GameObject newProjectile;
	private GameObject newProjectile2;
	private float myTime = 0.0F;

	void Update() {

		myTime = myTime + Time.deltaTime;

		if (Input.GetButton("Fire1") && myTime > nextFire) {
			nextFire = myTime + fireDelta;
			newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;

			// create code here that animates the newProjectile   
			newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward*(fireForce));


			nextFire = nextFire - myTime;
			myTime = 0.0F;


		}

		if (Input.GetButton("Fire2") && myTime > nextFire) {
			nextFire = myTime + fireDelta;
			newProjectile2 = Instantiate(projectile2, transform.position, transform.rotation) as GameObject;

			// create code here that animates the newProjectile   
			newProjectile2.GetComponent<Rigidbody>().AddForce(transform.forward*(fireForce));


			nextFire = nextFire - myTime;
			myTime = 0.0F;
		}
	}
}
