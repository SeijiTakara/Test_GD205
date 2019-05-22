using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_02 : MonoBehaviour
{
    public GameObject Bullet_Emitter;


    public GameObject Bullet;

    public AudioSource beamShot;
    public float bulletSpeed = 30;

    public float lifeTime = 3;



    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shot();
           
        }
    }
    private void Shot()
    {
        GameObject tBullet = Instantiate(Bullet);
        Physics.IgnoreCollision(tBullet.GetComponent<Collider>(),Bullet_Emitter.GetComponentInParent<Collider>());
        tBullet.transform.position = Bullet_Emitter.transform.position;
        Vector3 rotation = tBullet.transform.rotation.eulerAngles;
        tBullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);
        tBullet.GetComponent<Rigidbody>().AddForce(Bullet_Emitter.transform.forward * bulletSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyBullet(tBullet, lifeTime));
        beamShot.Play();
        
    }
    private IEnumerator DestroyBullet(GameObject tBullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(tBullet);
        
    }
}
