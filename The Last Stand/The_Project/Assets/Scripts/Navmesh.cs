using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Navmesh : MonoBehaviour
{

    [SerializeField]
    private Transform target;
   
    private GameObject pauseMenuUI;
    private bool isStopped;
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
       
        if (target == null) // Stop acsess to navmesh + -> Mainmenu
        {
            
            SceneManager.LoadScene(0);
        }
        else
        {
            nav.SetDestination(target.position);
        }

       

    }
  





}
