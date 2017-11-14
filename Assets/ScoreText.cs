using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour {
	

	private GameObject tokuten;
	private GameObject ball;

//	private PointController ballpointcontroller;

	// Use this for initialization
	void Start () {
		
		this.tokuten = GameObject.Find("ScoreText");
		this.ball = GameObject.Find ("Ball");
	}

	// Update is called once per frame
	void Update () {

//		ballpointcontroller = this.ball.GetComponent<PointController> ();
//		int score = ballpointcontroller.score;

			//GameoverTextにゲームオーバを表示
//		this.tokuten.GetComponent<Text> ().text = score.ToString();

		this.tokuten.GetComponent<Text> ().text = this.ball.GetComponent<PointController> ().score.ToString();
	}
}
