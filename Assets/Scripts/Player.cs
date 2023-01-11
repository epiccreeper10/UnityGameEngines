using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public GameObject prefab;

    private void Awake()
    {
        Debug.Log("awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = new Vector3(, 3, 2);
        //transform.rotation = Quaternion.Euler(Random.value, Random.value, Random.value);
        //transform.localScale = Vector3.one * Random.value * 5;

        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(prefab, transform.position, transform.rotation);
        }

        //if (Input.GetKey(KeyCode.A)) direction.x = -1;
        //if (Input.GetKey(KeyCode.D)) direction.x = 1;
        //if (Input.GetKey(KeyCode.W)) direction.z = 1;
        //if (Input.GetKey(KeyCode.S)) direction.z = -1;

        transform.position += direction * speed * Time.deltaTime;
    }
}
