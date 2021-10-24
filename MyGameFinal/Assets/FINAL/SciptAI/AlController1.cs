    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.AI;
public class AI: MonoBehaviour
    {
        // Start is called before the first frame update
        NavMeshAgent agent;
        public GameObject target;
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();

        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(target.transform.position);
        }
    }