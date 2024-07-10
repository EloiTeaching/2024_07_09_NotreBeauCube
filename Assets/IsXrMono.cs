using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IsXrMono : MonoBehaviour
{

    public string m_nameOfResourceToLookAround= "IsXR";
    public UnityEvent m_onIsXR;
    public UnityEvent m_onIsNotXR;
    public UnityEvent<bool> m_onIsXrBool;

    public bool m_isXR;
    void Start()
    {
      Object o =  Resources.Load(m_nameOfResourceToLookAround);
        m_isXR = o != null;
        if (m_isXR)
        {
            m_onIsXR.Invoke();
            m_onIsXrBool.Invoke(true);
        }
        else {

            m_onIsNotXR.Invoke();
            m_onIsXrBool.Invoke(false);
        
        }
    }

   
}
