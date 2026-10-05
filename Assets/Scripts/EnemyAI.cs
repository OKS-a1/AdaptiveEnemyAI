using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform[] points;
    public Transform player;

    public float waitTime = 1f;
    public float detectRange = 10f;
    public float searchTime = 5f;

    NavMeshAgent a;
    EnemyMemory memory;

    int i;
    float t;
    float searchTimer;

    bool chasing;
    bool searching;

    Vector3 lastKnownPosition;

    void Start()
    {
        a = GetComponent<NavMeshAgent>();
        memory = GetComponent<EnemyMemory>();
        Go();
    }

    void Update()
    {
        float d = Vector3.Distance(transform.position, player.position);

        if (d <= detectRange)
        {
            if (!chasing)
            {
                memory.Remember(player.position);
            }

            chasing = true;
            searching = false;

            lastKnownPosition = player.position;
            a.SetDestination(player.position);

            return;
        }

        if (chasing && !searching)
        {
            chasing = false;
            searching = true;
            searchTimer = 0;

            Vector3 target = memory.GetBestLocation();
            a.SetDestination(target);

            return;
        }

        if (searching)
        {
            searchTimer += Time.deltaTime;

            if (searchTimer >= searchTime)
            {
                searching = false;
                Go();
            }

            return;
        }

        if (!a.pathPending && a.remainingDistance <= a.stoppingDistance)
        {
            t += Time.deltaTime;

            if (t >= waitTime)
            {
                i = (i + 1) % points.Length;
                Go();
                t = 0;
            }
        }
    }

    void Go()
    {
        if (points.Length > 0)
            a.SetDestination(points[i].position);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRange);
    }
    void OnGUI()
    {
        Vector3 best = memory.GetBestLocation();
        int score = memory.GetBestScore();

        string state = "PATROL";

        if (chasing)
            state = "CHASE";
        else if (searching)
            state = "SEARCH";

        GUI.Box(
            new Rect(15, 15, 280, 130),
            "ADAPTIVE ENEMY AI"
        );

        GUI.Label(
            new Rect(30, 45, 250, 25),
            "State: " + state
        );

        GUI.Label(
            new Rect(30, 70, 250, 25),
            "Detection Range: " + detectRange
        );

        GUI.Label(
            new Rect(30, 95, 250, 25),
            "Memory: " + best
        );

        GUI.Label(
            new Rect(30, 120, 250, 25),
            "Memory Score: " + score
        );
    }
}
