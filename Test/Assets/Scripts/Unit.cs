using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Unit : MonoBehaviour
{
    private NavMeshAgent _agent;
    private GameObject _model;
    private List<Effect> _effects;
    private Stats _stats;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goTo(Vector3 pos)
    {
        
    }

    public void goTo(Unit unit)
    {
        
    }

    public void attack(Unit target)
    {
        
    }

    public IEnumerator addEffect(Effect e)
    {
        
    }

    public bool isDead()
    {
        
    }

    public int getTeam()
    {
        
    }
}
