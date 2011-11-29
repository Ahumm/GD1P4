using UnityEngine;
using System.Collections;

public class destroyableObjectsScript : MonoBehaviour {
	
	private float hitTime = 0.0f;
	public Transform spawn;
	
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
				for(int i = 0; i < 5; i++){
					Instantiate(spawn, transform.position + Random.insideUnitSphere * 10, transform.rotation);
				}
				Destroy(gameObject);
			}
		}
	}
}
