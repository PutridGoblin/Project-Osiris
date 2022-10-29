using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject fractured;
    public float breakForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("b"))
		{
            BreakdownBreakdown();
		}
    }

    public void BreakdownBreakdown()
	{
        GameObject fracturedObject = Instantiate(fractured, transform.position, transform.rotation);

        foreach(Rigidbody rb in fracturedObject.GetComponentsInChildren<Rigidbody>())
		{
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
		}

        Destroy(gameObject);
	}
}
