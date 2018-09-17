﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_Enemy2 : MonoBehaviour {

	public float speed;
	public float timer;
	public Rigidbody2D rb;
	public SpriteRenderer sp;
	public bool turn;

	void Start () {
		turn = true;
		speed *= 10;
		StartCoroutine("TurnTime");
	}
	void FixedUpdate () {
		rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
	}
	IEnumerator TurnTime(){
		while(turn){
			yield return new WaitForSeconds(timer);
			speed *= -1;
			sp.flipX = !sp.flipX;
		}
	}
}
