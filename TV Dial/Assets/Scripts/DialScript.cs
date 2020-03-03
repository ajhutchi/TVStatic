using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialScript : MonoBehaviour
{
    public Camera m_camera;
    public GameObject m_dialTick;
    private int m_nCurrChannel = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = m_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                m_dialTick.transform.localEulerAngles += new Vector3(0.0f, 120.0f, 0.0f);
                if(m_nCurrChannel == 3)
                {
                    m_nCurrChannel = 1;
                } else
                {
                    m_nCurrChannel++;
                }
            }
        }
    }

    public int GetChannel()
    {
        return m_nCurrChannel;
    }
}
