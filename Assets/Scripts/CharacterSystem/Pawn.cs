using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//A class for all charcters, animals, to have basic functions
public class Pawn : MonoBehaviour, IMoveable
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;
    private GameObject moveLocation;
    private GameObject food;
    private NavMeshAgent agent;

    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public virtual void Eat()
    {

        if (Food.Foods.Count != 0)
        {
            food = Food.Foods[Random.Range(0, Food.Foods.Count)];
            Move(food.transform.position);
            StartCoroutine(MoveAndEat(food));
        }

    }

    public void Move(Vector3 moveLocation)
    {
        agent.SetDestination(moveLocation);



    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 50, 30), "Eat"))
            Eat();

    }

    protected bool pathComplete()
    {
        if (Vector3.Distance(agent.destination, agent.transform.position) <= agent.stoppingDistance)
        {
            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
            {
                return true;
            }
        }

        return false;
    }

    private void Update()
    {

    }

    IEnumerator MoveAndEat(GameObject target)
    {
        while (Vector3.Distance(agent.transform.position, target.transform.position) > 1f)

        {


            yield return new WaitForSeconds(.1f);
        }

        print("Reached the target.");
        if (food != null)
        {
            food.GetComponent<Food>().Eat(food);
        }

    }
}





