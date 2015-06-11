using UnityEngine;
using System.Collections;

public class FloorController : MonoBehaviour {

	public GameObject[] floor;
	public GameObject actualFloor;

	// Use this for initialization
	void Start () {
		Vector3 beforePlayer = transform.position;
		beforePlayer.y -= 6.48f;
		actualFloor = Instantiate(actualFloor, beforePlayer, Quaternion.identity) as GameObject;
		actualFloor = Instantiate(actualFloor, transform.position, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(actualFloor.transform.position, transform.position) < 10){
			Vector2 end = actualFloor.transform.GetChild(0).position;
			actualFloor = Instantiate(floor[0], end, Quaternion.identity) as GameObject;
		}
	}
}
