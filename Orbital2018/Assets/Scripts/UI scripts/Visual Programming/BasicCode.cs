﻿using UnityEngine;

public class BasicCode : MonoBehaviour {

    public Transform towerRef;
    public TagMasterSO tagmasterso;

    public virtual void Run() {
        Debug.Log("By default this does nothing");
        foreach (Transform child in transform) {
            if (child.tag == tagmasterso.DummyTag) continue;   
            child.GetComponent<BasicCode>().Run();
        }
    }

    public virtual bool RunCheck()
    {
        return true;
    }

    public virtual void SetTowerRef(Transform reference) {
        towerRef = reference;
        Debug.Log(towerRef.name);
    }

	public Transform GetTowerRef() {
		return towerRef;
	}
}
