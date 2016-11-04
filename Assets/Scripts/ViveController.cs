using UnityEngine;
using System.Collections;

public class ViveController : MonoBehaviour {

    public MeshCollider CaveCollider;
    public bool IsInValidSpace;

    void OnTriggerEnter(Collider other)
    {
        if (other == CaveCollider)
        {
            if(IsInValidSpace)
            {
                Debug.Log("Vivecontroller hit cave collider" + Time.realtimeSinceStartup);
            }
            IsInValidSpace = false;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other == CaveCollider)
        {
            if (!IsInValidSpace)
            {
                Debug.Log("Vivecontroller left cave collider" + Time.realtimeSinceStartup);
            }

            IsInValidSpace = true;
        }
    }
}
