using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcMovimento : MonoBehaviour
{
    
    public Transform minerio;
    public Transform storage;

    public NavMeshAgent minerador;

    bool estado;
    // Start is called before the first frame update
    void Start()
    {
        minerador.SetDestination(minerio.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "minerio")
        {
            minerador.SetDestination(storage.transform.position);
            Debug.Log("coletou");
        }
        else if (other.gameObject.tag == "storage")
        {
            minerador.SetDestination(minerio.transform.position);
            Debug.Log("depositou");
        }
    }
}
