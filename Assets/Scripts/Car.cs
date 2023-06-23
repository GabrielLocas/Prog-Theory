using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Car : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance != null)
            speed = MainManager.Instance.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    public override void Move()
    {
        gameObject.transform.Translate(Vector3.forward * speed);
    }

    public override void UseAbility()
    {
        //Nothing
    }
}
