using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public void ManipulateTime(float newTime, float duration){
		if (Time.timeScale == 0) {
			Time.timeScale = 0.1;
		}
	}


}
