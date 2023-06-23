using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Tank : Vehicle
{
    [SerializeField] private GameObject spawnManager;
    [SerializeField] private SpawnManager spawnManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager");
        spawnManagerScript = spawnManager.GetComponent<SpawnManager>();
        if (MainManager.Instance != null)
            speed = MainManager.Instance.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UseAbility();
        }
    }

    // POLYMORPHISM
    public override void Move()
    {
        gameObject.transform.Translate(Vector3.forward * speed);
    }


    // ABSTRACTION + POLYMORPHISM
    public override void UseAbility()
    {
        spawnManagerScript.Shoot();
    }
}
