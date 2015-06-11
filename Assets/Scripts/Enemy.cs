using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform player;
	public Transform aim;
	public GameObject bullet;

	public float timeToShoot;

	private float currentTimeToShoot;
	private Quaternion rotation;

	public float distanceFromCamera = 10.0f;

	void Start(){
		player = GameObject.Find("Player").transform;
	}

	void Update(){
		rotation = Quaternion.LookRotation(transform.position - player.position, Vector3.forward);
		rotation.x = 0.0f;
		rotation.y = 0.0f;
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 8);
		currentTimeToShoot += Time.deltaTime;
		if(currentTimeToShoot > timeToShoot){
			GameObject tempBullet = Instantiate(bullet.gameObject, aim.position, aim.rotation) as GameObject;
			currentTimeToShoot = 0;
		}
	}
}