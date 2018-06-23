using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Zombie  {

    int afterLife = 10;
    int brainsEaten = 0;
    float stumbleSpeed = 2.1f;

    public void TakeDamage(int damage, bool isFire)
    {
        if (!isFire)
        {
            afterLife -= damage;
        }

        else
        {
            afterLife -= damage * 2;
        }
    }

}
