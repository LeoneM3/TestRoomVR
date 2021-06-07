using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ProfeController : MonoBehaviour
{

    public Transform[] wayPoints;
    public int time;
    public int timeRest;
    public Transform target;
    public Transform detect;
    private float timeTrans;
    private int nextPoint;
    private int lastPoint;
    private NavMeshAgent Profesor;
    private Animator ProfesorAnim;

    void Awake()
    {
        Profesor = GetComponent<NavMeshAgent>();
        ProfesorAnim = GetComponent<Animator>();
        lastPoint = wayPoints.Length;

    }
    void Start()
    {
        ProfesorMove();
        // EscritorioDetect();
    }
    void ProfesorMove()
    {
        timeTrans += Time.deltaTime;
        time = Mathf.RoundToInt(timeTrans);

        if (time == timeRest)
        {
            nextPoint = Random.Range(0, lastPoint);
            Profesor.destination = wayPoints[nextPoint].position;
            timeTrans = 0;
            time = 0;
            ProfesorAnim.SetBool("Walk", true);
        }

        int distance = Mathf.RoundToInt(Vector3.Distance(transform.position, wayPoints[nextPoint].position));

        if(distance == 0)
        {
            ProfesorAnim.SetBool("Walk", false);
        }
    }

    //void EscritorioDetect()
   // {
      //  detect.LookAt(target);
       // Vector3 fwd = detect.TransformDirection(Vector3.forward);
       // RaycastHit hit;

       // if (Physics.Raycast(detect.position, fwd, out hit, 5f) && hit.collider.CompareTag("Player"))
        //{
        //    Profesor.isStopped = true;
        //   transform.LookAt(target);
        //    ProfesorAnim.SetBool("Walk",false);
         //   ProfesorAnim.SetBool("IdleAim", true);

       // }
       //else
       // {
        //    Profesor.isStopped = false;
        //    ProfesorAnim.SetBool("IdleAim", false);
       // }
   // }
    
   }
