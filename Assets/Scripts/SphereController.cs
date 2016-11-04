using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

    public ViveController RightGameController;
    public ParticleSystem Particles;
    public MeshCollider CaveCollider;
    private bool _attachedToLight = false;
    private bool _isHit = false;
   
	// Use this for initialization
	void Start () {
        Debug.Log("starting sphere controller" + Time.realtimeSinceStartup);
    }
	
	// Update is called once per frame
	void Update () {
        if ((RightGameController.transform.position - this.transform.position).magnitude < .1f || _attachedToLight)
        {
            // First time we´re close attach for good.
            _attachedToLight = true;
            if (RightGameController.IsInValidSpace)
            {
                this.transform.position = RightGameController.transform.position;
                Particles.Stop();
            }
            else
            {
                Particles.Play();
            }
        }
    }
    /**
    void OnTriggerEnter(Collider other)
    {
        if(other == CaveCollider)
        {
            Debug.Log("hit");
            _isHit = true;
            Particles.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other == CaveCollider)
        {
            Debug.Log("exit");
            _isHit = false;
            Particles.Stop();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("hit");
        //Destroy(gameObject);
    }
    **/
}
