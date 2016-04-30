using UnityEngine;
using System.Collections;

public class FireDestroy : MonoBehaviour
{
    public GameObject upInSmokePrefab;

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "SeaFloor") || (col.gameObject.tag == "Water"))
        {
            Destroy (gameObject);
        }
        if (col.gameObject.tag == "Enemy")
        {
            Vector3 pos = new Vector3 (col.gameObject.transform.position.x, 0, col.gameObject.transform.position.z);
            GameObject upInSmoke = (GameObject) Instantiate (upInSmokePrefab, pos, new Quaternion(270, 0, 0, 0));

            SpawnPosition.pushIndex(SpawnPosition.spawnPositions[col.gameObject.name]);

            col.gameObject.GetComponent<Rigidbody> ().centerOfMass = new Vector3 (0, 0, 1);

            Destroy (col.gameObject);
            Destroy (upInSmoke, 5f);
        }
    }
}
