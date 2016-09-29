using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour{

	[SerializeField]
	GameObject explosion = null;

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag == "island"){
			Player.Instance.points += 100;


			Debug.Log ("Collision with " +
			other.gameObject.tag);
		}else if(other.gameObject.tag == "enemy"){
			Player.Instance.health -= 10;
			Debug.Log("Collision with " + other.gameObject.tag);


			ShipController sp = 
				other.gameObject.GetComponent<ShipController> ();
		
			if(sp != null) {
				//show explosion
				GameObject ex = 
					Instantiate (explosion);
				ex.transform.position = 
					sp.transform.position;
				//Reset ship
				sp.Reset ();
			}
		
			AudioSource asrc = gameObject.GetComponent<AudioSource>();
			if (asrc != null) {
				asrc.Play ();
			}
		}

	}
}
