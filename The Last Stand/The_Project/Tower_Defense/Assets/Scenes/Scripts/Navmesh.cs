using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    private NavMeshAgent nav;

    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("player").gameObject.transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
    }
}
