using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPosition : MonoBehaviour
{
    public static Dictionary<string, Vector3> spawnPositions = new Dictionary<string, Vector3> ();
    public static ArrayList indices = new ArrayList {new ArrayList {-100, -100}, new ArrayList {-100, 100},
        new ArrayList {100, -100}, new ArrayList {100, 100}, new ArrayList {100, 0},
        new ArrayList {0, 100}, new ArrayList {-100, 0}, new ArrayList {0, -100}};

    public static void pushIndex(Vector3 vec)
    {
        indices.Add (new ArrayList { (int)vec.x, (int)vec.z });
    }
}
