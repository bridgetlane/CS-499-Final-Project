using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
    private CardboardHead head;
    public float bulletSpeed = 10;
    public GameObject ballOfFlamePrefab;

    void Start ()
    {
        Cardboard.SDK.OnTrigger += On_Click;
        head = Camera.main.GetComponent<StereoController>().Head;
    }

    void On_Click()
    {
        Fire ();
    }

    void Fire()
    {
        Cardboard.SDK.UpdateState();
        head = Camera.main.GetComponent<StereoController>().Head;
        Ray r = head.Gaze;
        GameObject ballOfFlame = (GameObject) Instantiate (ballOfFlamePrefab, new Vector3(0, 1, 0), new Quaternion(270, 0, 0, 0));
        ballOfFlame.GetComponent<Rigidbody>().velocity = r.direction * bulletSpeed;
    }

    void Update()
    {
        Cardboard.SDK.UpdateState();
    }
}
