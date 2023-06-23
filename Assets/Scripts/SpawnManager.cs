using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject projectile;
    [SerializeField] private Rigidbody projectile_Rb;
    [SerializeField] private List<GameObject> vehicleList;
    [SerializeField] private GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance != null)
        {
            vehicle = vehicleList[MainManager.Instance.carType];
        }
        else
        {
            vehicle = vehicleList[0];
        }

        // Spawn car
        Instantiate(vehicle, new Vector3(0, 0, 0), vehicle.transform.rotation);
        projectile_Rb = projectile.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        Instantiate(projectile, vehicle.transform.position, projectile.transform.rotation);
        projectile_Rb.AddForce(Vector3.forward * 1000);
    }
}
