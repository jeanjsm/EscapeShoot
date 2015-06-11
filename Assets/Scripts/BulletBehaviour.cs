using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class BulletBehaviour : MonoBehaviour {

	public float speed;
	public int damage;

	// Player
	private PlayerBehaviour player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType(typeof(PlayerBehaviour)) as PlayerBehaviour;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	
	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.tag == "Player"){
			Debug.Log("Entrou");
			player.ApplyDamage(damage);
			Destroy(gameObject);
		}
	}
}
