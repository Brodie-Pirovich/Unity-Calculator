using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Camera playerCamera;

    [SerializeField]
    private Transform rocket;

    [SerializeField]
    private Transform muzzle;

    private float shootDelayed;
    public float shotsPerMinute;
    private float shootElapsed;

    public GameObject[] cubes;


    void Awake()
    {
        shootDelayed = shotsPerMinute / 60.0f;
    }

    void Update()
    {
        shootElapsed += Time.deltaTime;

        if (Input.GetButton("Fire1") && shootElapsed >= shootDelayed)
        {
            shootElapsed = 0.0f;
            Debug.Log("ReadyToFIre");
            Fire();
            cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (GameObject cube in cubes)
            {
                cube.GetComponent<Cube>().b_kin = false;
            }
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space pressed");
            foreach (GameObject cube in cubes)
            {
                cube.GetComponent<Cube>().b_kin = true;
                cube.transform.position = cube.GetComponent<Cube>().initalPos;
                cube.transform.rotation = cube.GetComponent<Cube>().initalRot;
            }
        }
    }

    public void Fire()
    {
        Vector3 startPont = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
        Vector3 fireDirection = playerCamera.transform.forward;
        Quaternion fireRotation = Quaternion.LookRotation(fireDirection);

        Transform tempRocket = Instantiate(rocket, muzzle.position, fireRotation);
        tempRocket.GetComponent<Rocket>().Setup(fireDirection);
    }
}
