using UnityEngine;
using System.Collections;

public class Activable : MonoBehaviour {

	public static GUI GUI;

	public static float loadingTime = 15;
	public static float startTime = 0;

	public static void start () {

		startTime = Time.time;
	}

	public static bool isTimeStarted() {
		return startTime > 0;
	}
	
	public static bool isReady () {
		return (startTime + loadingTime) < Time.time;
	}
	
	public static void reset() {
		startTime = 0;
	}
}
