using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public GameObject[] floor;
	public GameObject actualFloor;

	// Use this for initialization
	void Start () {
		actualFloor = Instantiate(actualFloor, transform.position, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(actualFloor.transform.position, transform.position) < 50){
			Vector2 end = actualFloor.transform.GetChild(0).position;
			actualFloor = Instantiate(floor[0], end, Quaternion.identity) as GameObject;
		}
	}
}
