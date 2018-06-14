using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour {

    void Start()
    {
        Zombie z = new Zombie();
        Vampire v = new Vampire();
        Debug.Log(z.TakeDamage(5));
        Debug.Log(v.TakeDamage(5));
        z.hitPoints = 10;
        v.hitPoints = 10;
        
    }

    void Update()
    {
      //  Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
    }

    //Vector3 direction;

    void OnDrawGizmos()
    {
        //Gizmos.DrawLine(transform.position, transform.position + direction);
        Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
    }

    class Monster
    {
        public int hitPoints;
        public GameObject gameObject;

        //constructor
        public Monster()
        {
            hitPoints = 10;
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Debug.Log("Un nuevo monstruo surge");
        }

        public virtual int TakeDamage(int damage)
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
            gameObject.transform.position = new Vector3(1, 0, 0);
        }

        public override string ToString()
        {
            return string.Format("[Zombie]");
        }

    }

    class Vampire : Monster
    {
        public int bloodSucked = 0;

        public override int TakeDamage(int damage)
        {
            return hitPoints - (damage / 2);
            //return base.TakeDamage(damage);
        }

    }

}
