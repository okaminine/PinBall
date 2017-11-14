using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour {
	

	private GameObject tokuten;
	private GameObject ball;



	// Use this for initialization
	void Start () {
		
		this.tokuten = GameObject.Find("ScoreText");
		this.ball = GameObject.Find ("Ball");
	}

	// Update is called once per frame
	void Update () {

		this.tokuten.GetComponent<Text> ().text = this.ball.GetComponent<PointController> ().score.ToString();
	}
}
