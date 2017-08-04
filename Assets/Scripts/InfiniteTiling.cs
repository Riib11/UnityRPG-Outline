using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteTiling : MonoBehaviour {

	public Transform player;
	public GameObject[] toTile;

	float size = 10.5f;

	// Use this for initialization
	void Start () {
		// on each side
		for (int i = -1; i <= 1; i++) { for (int j = -1; j <= 1; j++) {
			if (!(i==0 && j==0)) {
				for (int o = 0; o < toTile.Length; o++) {
					GameObject tile = GameObject.Instantiate (toTile[o]);
					tile.transform.Translate (size * i, size * j, 0f);
				}
			}
		}}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = player.position;
		float hs = size / 2;
		if (pos.x < -hs) { pos.x += size; }
		if (pos.x > hs) {pos.x -= size; }
		if (pos.y < -hs) {pos.y += size; }
		if (pos.y > hs) {pos.y -= size; }
		player.position = pos;
	}
}
