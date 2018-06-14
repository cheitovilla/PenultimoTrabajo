using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGenerator : MonoBehaviour {


    public int numMonsters;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < numMonsters; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.AddComponent<Monsters>();
            Vector3 pos = new Vector3();
            pos.x = Random.Range(-10, 10);
            pos.z = Random.Range(-10, 10);
            sphere.transform.position = pos;
        }

	}

	// Update is called once per frame
	void Update () {
		
	}
}
