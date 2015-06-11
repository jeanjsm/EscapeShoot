using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class PlayerBehaviour : MonoBehaviour {

	public float speed;
	public float startLife;

	public float currentLife;
	private Vector2 move;

	// Use this for initialization
	void Start () {
		currentLife = startLife;
	}
	
	// Update is called once per frame
	void Update () {
		Move (Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
	}

	void Move(float acceleration, float accLateral){
		move = new Vector2(accLateral, acceleration);
		transform.Translate(move * speed * Time.deltaTime);
	}

	public void ApplyDamage(float damage){
		currentLife -= damage;
	}
}
