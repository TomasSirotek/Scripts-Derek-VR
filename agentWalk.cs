
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class agentWalk : MonoBehaviour
{
    public NavMeshAgent playerAgent;

    public Rigidbody rb;

    public Animator animator;


    [SerializeField]

    public Transform goal;
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    /// <summary>
    /// Update is called once per frame
    /// </summary> 
    void Update()
    {
        playerAgent.destination = goal.position;
        ;
        animator.SetBool("isWalking", true);

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("test"))
        {

            SceneManager.LoadScene("StartingMenu");

            Debug.Log("LoadSceneStartingScene");

        }

    }
}
