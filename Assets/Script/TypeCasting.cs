using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting : MonoBehaviour {


    void Start()
    {
        //   Humanoid h = new Humanoid();
        //  Zombie z = h as Zombie;
        // Debug.Log(z);

        //Humanoid h = new Humanoid();
        //Zombie x = (Zombie)h;
        //Debug.Log(x);
        /*
        Person p = new Person();
        p.hitpoints = 10;
        Zombie z = p as Person;
        Debug.Log(z.hitpoints); */

        Person p = new Person();
        Zombie z = (Zombie)p;
        Debug.Log(z);


    }


    class Humanoid
    {
        public int hitpoints;
    }

    class Zombie : Humanoid
    {

    }

    class Person : Humanoid
    {
        static public implicit operator Zombie(Person p)
        {
            Zombie z = new Zombie();
            z.hitpoints = p.hitpoints * -1;
            return z;
        }



    }


}
