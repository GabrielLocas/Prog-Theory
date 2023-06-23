using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    [SerializeField] protected float speed;


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

    public virtual void Move()
    {
        gameObject.transform.Translate(Vector3.back * speed);
    }

    public abstract void UseAbility();
 
}
