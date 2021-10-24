using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllersRigidbody : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 1f;
    public float rotSpeed = 0.1f;
    float newRotY = 0;
    public GameObject prefabBullet;
    public Transform gunPosition;
    public float gunPower = 15f;
    public float gunCooldown = 2f;
    public float gunCooldownCount = 0;
    public bool hasGun = false;
    public int  bulletCount=0;
    public int coinCount = 0;
    public Text uiScore;
    public PlaygroundSceneManager manager ;
    public AudioSource audiocoin;
    public AudioSource audiofire;
    //public AudioSource audiocollect;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        manager = FindObjectOfType<PlaygroundSceneManager>();
        if (manager == null)
        {
            print("Manager Not found!!!!");
        }
        if (PlayerPrefs.HasKey("CoinCount"))
        {
            coinCount = PlayerPrefs.GetInt("CoinCount");
        }
        manager.SetScore(coinCount);
    }

    void FixedUpdate()
    {
        /* 
         if (Input.GetKey(KeyCode.UpArrow))
         {
             rb.AddForce(0, 0, +speed, ForceMode.VelocityChange);
             newRotY = 0;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             rb.AddForce(0, 0, -speed, ForceMode.VelocityChange);
             newRotY = 180;
         }
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             rb.AddForce(-speed, 0, 0, ForceMode.VelocityChange);
             newRotY = -90;
         }
         if (Input.GetKey(KeyCode.RightArrow))
         {

             rb.AddForce(+speed, 0, 0, ForceMode.VelocityChange);
             newRotY = 90;

         }
        */
        float horizontal = Input.GetAxis("Horizontal")*speed;
        float vertical = Input.GetAxis("Vertical")*speed;
        if (horizontal > 0)
        {
            newRotY = 90;
        }
        else if (horizontal < 0)
        {
            newRotY = -90;
        }

        if (vertical > 0)
        {
            newRotY = 0;
        }
        else if (vertical < 0)
        {
            newRotY = 180;
        }
        rb.AddForce(horizontal, 0, vertical,ForceMode.VelocityChange);
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, newRotY, 0), transform.rotation, rotSpeed);

    }
    private void Update()
    {
        //Fire
        gunCooldownCount += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftControl) && bulletCount>0 && gunCooldownCount >= gunCooldown)
        {

            gunCooldownCount = 0;
            GameObject bullet = Instantiate(prefabBullet, gunPosition.position, gunPosition.rotation);
            Rigidbody bRb = bullet.GetComponent<Rigidbody>();
            bRb.AddForce(transform.forward * gunPower, ForceMode.Impulse);

            Destroy(bullet, 2f);
            bulletCount--;
            manager.SetTextbullet(bulletCount);
            audiofire.Play();

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       /* if (collision.gameObject.tag == "เสา")
        {
            print(collision.gameObject.name);
        }

        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Fakeball")
        {
            Destroy(collision.gameObject);
        }*/
        if (collision.gameObject.tag == "Collectables")
        {   
            print(collision.gameObject.name);
            Destroy(collision.gameObject);
            coinCount ++ ;
            manager.SetScore(coinCount);
            audiocoin.Play();
            PlayerPrefs.SetInt("CoinCount",coinCount);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gun")
        {
            print(other.gameObject.name);
            print("I have Gun!!!!!!");
            Destroy(other.gameObject);
            hasGun = true;
            bulletCount =+10;
            manager.SetTextbullet(bulletCount);
            //audiocollect.Play();
        }
    }
}

/*
 private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            Destroy(other.gameObject);
        }
         if (other.gameObject.tag == "เสา")
        {
        Destroy(other.gameObject);
        }

    if (other.gameObject.tag == "ball")
    {
        Destroy(other.gameObject);
    }

    if (other.gameObject.tag == "Fakeball")
    {
        Destroy(other.gameObject);
    }*/
