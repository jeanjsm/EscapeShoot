using UnityEngine;
using System.Collections;

public class ObjectDestroyTimedBehaviour : MonoBehaviour {

	public float timeToDestroy;
	private float currentTimeToDestroy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTimeToDestroy += Time.deltaTime;
		if(currentTimeToDestroy > timeToDestroy){
			Destroy(gameObject);
		}
	}
}
