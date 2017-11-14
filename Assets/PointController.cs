using UnityEngine;
using System.Collections;

public class PointController : MonoBehaviour {

	public int score = 0;


		void Start () {

			

		}

		// Update is called once per frame
		void Update () {
		
			


		}

		//衝突時に呼ばれる関数
		void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "SmallStarTag") {
				this.score += 10;
		} else if (collision.gameObject.tag == "LargeStarTag") {
				this.score += 20;
		}else if(collision.gameObject.tag == "SmallCloudTag" || collision.gameObject.tag == "LargeCloudTag") {
				this.score +=30;
			}
		}
	}