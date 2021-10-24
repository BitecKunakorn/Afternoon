using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chractercontrollerRigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speed = 2f;
    public int LightCount = 0;
    public AudioSource audiocoin;
    public LevelSceneManager manager;
    public Text TextLightCount;
    //public Text  uiTextLightCount;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        manager = FindObjectOfType<LevelSceneManager>();
        if (manager == null)
        {
            print("Manager Not found!!!!");
        }
        /*if (PlayerPrefs.HasKey("LightCount"))
        {
            LightCount = PlayerPrefs.GetInt("LightCount");
        }*/
        //manager.SetTextLightCount(LightCount);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed, 0, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            print(collision.gameObject.name);
            Destroy(collision.gameObject);
            LightCount++;
            manager.SetTextLightCount(LightCount);
            audiocoin.Play();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            print(collision.gameObject.name);
            print("Your dead !!!!");
            Destroy(collision.gameObject);
        }
    }
}
