using UnityEngine;
using System.Collections;

public class destroyableObjectsScript : MonoBehaviour {
	
	private float hitTime = 0.0f;
	
	// Time it takes to die
	public float deathTime = 3.0f;
	
	// Time Tracker
	private float prevTimeMoment = 0.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnParticleCollision(GameObject other){
		if(Time.time != prevTimeMoment){
			prevTimeMoment = Time.time;
			
			hitTime += Time.deltaTime;
			
			if(hitTime >= deathTime){
				// Do death stuff
			}
		}
	}
}
