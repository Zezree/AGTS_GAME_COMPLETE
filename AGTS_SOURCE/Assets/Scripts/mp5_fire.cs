using UnityEngine;
using System.Collections;

public class mp5_fire : base_fire
{
    //Počet střel a ryhlost střílení na objektu MP5
	public override void Start()
	{
		player = GameObject.Find(name);
		anim = GameObject.Find(name).GetComponent<Animator>();
		playerHand = GameObject.Find(hand);
		shots = 150; //počet střel, je jich hodně tak aby bylo s čím střílet
		fireRate = 0.05f; //rychlost střílení
		base.Start();
	}
}
