using UnityEngine;
using System.Collections;

public class ObjectDestroyBehaviour : MonoBehaviour {

	public float timeToDestroy;
	private float currentTimeToDestroy;

	public bool timed;
	public bool distance;

	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(timed){
			currentTimeToDestroy += Time.deltaTime;
			if(currentTimeToDestroy > timeToDestroy){
				Destroy(gameObject);
			}
		}
		if(distance){
			transform.Translate(-Vector3.up * Time.deltaTime * 5f);
			if(Vector3.Distance(transform.position, player.transform.position) > 20){
				Destroy(gameObject);
			}
		}
	}
}
