using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Camera fpsCamera;

    public float firingRate = 15f;

    public float range = 100f;

    public GameObject Shot;

    public ParticleSystem gunflash;

    private float nextTimeFire = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1") && Time.time >= nextTimeFire)
        {
            nextTimeFire = Time.time + 1f / firingRate;
            ShootTheBullet();
        }
    }


    public void ShootTheBullet()
    {

        gunflash.Play();

        RaycastHit hit;

        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {

            GameObject ShotGO = Instantiate(Shot, hit.point, Quaternion.LookRotation(hit.normal));

            Destroy(ShotGO, 0.875f);
        }

        

   
        
    }
}
