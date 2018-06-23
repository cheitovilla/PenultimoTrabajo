using UnityEngine;
using System.Collections;

public class Monsters : MonoBehaviour
{
	public GameObject playerObject;

	void Start ()
	{
		Zombie z = new Zombie();
		Vampire v = new Vampire();
		z.hitPoints = 10;
		v.hitPoints = 10;
		Debug.Log (z.TakeDamage(5));
		Debug.Log (v.TakeDamage(5));

		//int number = (int)mState;
		//Debug.Log(number);
		Vector3 pos = new Vector3();
		pos.x = Random.Range(-10f, 10f);
		pos.z = Random.Range(-10f, 10f);
		transform.position = pos;
		GameObject[] AllGameObjects = GameObject.FindObjectsOfType (typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in AllGameObjects)
		{
			Component aComponent = aGameObject.GetComponent (typeof(Player));
			if (aComponent != null)	playerObject = aGameObject;
		}
	}

	Vector3 direction;// variable con alcance de clase
	public float attackRange = 5.0f;
	public float speedMultiplier = 0.09f;

	void Update ()
	{
//		if (mState == MonsterState.standing)
//		{
//			print("El monstruo está quieto");
//		}
//		if (mState == MonsterState.wandering)
//		{
//			print("El monstruo está rondando");
//		}
//		if (mState == MonsterState.chasing)
//		{
//			print("El monstruo está persiguiendo");
//		}
//		if (mState == MonsterState.attacking)
//		{
//			print("El monstruo está atacando");
//		}
		//direction = Vector3.Normalize (playerObject.transform.position - transform.position);
		//transform.position += direction * 0.1f;
		//Movemos el monstruo evaluando si	está a más de 3 unidades de distancia del jugador.

//		Vector3 myVector = playerObject.transform.position - transform.position;
//		float distanceToPlayer = myVector.magnitude;
//		if (distanceToPlayer > 3.0f)
//		{
//			direction = Vector3.Normalize(playerObject.transform.position - transform.position);
//			transform.position += direction*0.1f;
//		}

//------------------------------- Optimizacion de las lineas anteriores --------------------------------------------------
		Vector3 myVector = playerObject.transform.position - transform.position;
		//float distanceToPlayer = myVector.magnitude;
		//		if (distanceToPlayer > attackRange)
		//		{
		//			direction = Vector3.Normalize (playerObject.transform.position - transform.position);
		//			transform.position += direction*0.1f;
		//		}
		float distanceToPlayer = (playerObject.transform.position - transform.position).magnitude;

		if ((playerObject.transform.position - transform.position).magnitude < attackRange)
		{
			transform.position += Vector3.Normalize(playerObject.transform.position - transform.position)*speedMultiplier;
		}

	}

	void OnDrawGizmos()
	{
		//Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
		Gizmos.DrawLine(transform.position, transform.position + direction);
		// con esto los palitos del gizmo siguen al que tenga el scriip de player
	}

	class Monster
	{
		public int hitPoints;
		//public GameObject gameObject;
		// constructor
		public Monster()
		{
			hitPoints = 1;
		//	gameObject = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			Debug.Log("Un nuevo monstruo surge!");
		}

		public virtual int TakeDamage(int damage) //la palabra virtual permite sobreescribir una funcion
		{
			return hitPoints - damage;
		}
	}

	class Zombie : Monster
	{
		public int brainsEaten = 0;

		public Zombie()
		{
			Debug.Log("zombie constructor");
		//	gameObject.transform.position = new Vector3(1, 0, 0);
		}
		public override string ToString() // override le dice a la clase hija que olvide el codigo de su madre e implemente uno nuevo
		{
			return string.Format("[Zombie]");
		}
	}

	class Vampire : Monster
	{
		public int bloodSucked = 0;

		public override int TakeDamage(int damage)
		{
			return hitPoints - (damage/2);
		}
	}
}