using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text points = null;
	[SerializeField]
	Text health = null;


	void Start () {
		points.text = "Points: 0";
		health.text = "Health: 100";
		Player.Instance.hud = this;
	}

	void Update () { }
	public void UpdatePoints(){
		points.text = "Points: " + Player.Instance.points;
	}
	public void UpdateHealth(){
		health.text = "Health: " + Player.Instance.health;
	}
}
