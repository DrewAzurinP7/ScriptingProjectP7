using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform fireposition;
    public float bulletSpeed;

    private Inventory inventory;

    private void Awake()
    {
        inventory = GetComponent < Inventory >();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    void shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, fireposition.position, fireposition.rotation) as Rigidbody;
            bulletInstance.AddForce(fireposition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
        }
    }
}
