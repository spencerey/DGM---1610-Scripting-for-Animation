using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{

    public int curHp, maxHp, scoreToGive ; //stats
    public float moveSpeed, attackRange, yPathOffset; //movement
    private List<Vector3> path; //Coordinates for a path
    private GameObject target; //target to follow
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        //Get the components
        target = FindObjectOfType<PlayerController>().gameObject;

        //player = GameManager.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("UpdatePath", 0.0f, 0.5f);

        curHp = maxHp;

        
    }

    // Update is called once per frame
    void UpdatePath()
    {
        //Calculate a path to the target
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);

        path = navMeshPath.corners.ToList();
        
    }

    void ChaseTarget()
    {
        if(path.Count == 0)
            return;

        //move towards the closest path
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0, yPathOffset,0), moveSpeed * Time.deltaTime);
        if(transform.position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * angle;

        float dist = Vector3.Distance(transform.position, target.transform.position);
        
        if(dist <= attackRange)
           
        {  
            return;//player.TakeDamage(1);


          //  if(weapon.CanShoot())
           //     weapon.Shoot();
        }

       else 
       {
        ChaseTarget();
       }

    }
}
