﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDirectionControl : MonoBehaviour {
	public bool m_UseRelativeRotation = true;

	private Quaternion m_RelativeRotation;
	public void Start () 
	{
		m_RelativeRotation = transform.parent.localRotation;
	}
	
	void Update ()
	{
		if (m_UseRelativeRotation)
			transform.rotation = m_RelativeRotation;	
	}
}
