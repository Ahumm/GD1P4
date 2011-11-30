using UnityEngine;
using System.Collections;

public class bubbleScript : MonoBehaviour {
	
	public ParticleEmitter bubbleEmitter;
	
	// Use this for initialization
	void Start () {
	
		
		
		
		
		///ugewyudiuged
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("mouse 0")){
			bubbleEmitter.emit = true;
		}
		else{
			bubbleEmitter.emit = false;
		}
	}
}
