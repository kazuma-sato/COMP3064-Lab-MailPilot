using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text points = null;
	[SerializeField]
	Text health = null;

	[SerializeField]
	GameObject player = null;
	[SerializeField]
	GameObject button = null;

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

	public void GameOver(){
		points.gameObject.SetActive(false);
		health.gameObject.SetActive(false);
		player.SetActive(false);

	}
	public void ResetGame(){
		
	}
}
