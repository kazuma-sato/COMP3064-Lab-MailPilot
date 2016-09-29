using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {

	[SerializeField]
	GameObject explosion = null;

	void OnTriggerEnter2d(Collider2D other){

		if(other.gameObject.tag == "Island"){
			Debug.Log("This just happened... " + other.gameObject.tag);
		} else if(other.gameObject.tag == "Enemy"){
			Debug.Log("You hit a " + other.gameObject.tag);

			ShipController sp = other.gameObject.GetComponent<ShipController>();
			if (sp != null) {
				GameObject ex = Instantiate (explosion);
				ex.transform.position = sp.transform.position;

				sp.Reset ();
			}
		}
	}
}

CrossCampus by 