using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVManager : MonoBehaviour
{
    public GameObject m_goDial;
    private DialScript m_dsDialScript;
    private int m_nDesiredChannel = 1;
    private float m_fDesiredAngle = 0.0f;
    private float m_fPoints = 0.0f;
    private float m_fMinAngleForPoints = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_dsDialScript = m_goDial.GetComponent<DialScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        if(m_nDesiredChannel == m_dsDialScript.GetChannel())
        {
            //when the channel is correct
            float fCurrentAngle = 0.0f;
            float fAngleDifference = Mathf.Abs(m_fDesiredAngle - fCurrentAngle);
            if(fAngleDifference < m_fMinAngleForPoints)
            {
                m_fPoints += (m_fMinAngleForPoints = fAngleDifference);
            }
        }
    }

    void RandomizeWinCondition()
    {
        //randomize the angles
        m_nDesiredChannel = Random.Range(1, 4);
        m_fDesiredAngle = Random.Range(-70.0f, 70.0f);
    }
}
