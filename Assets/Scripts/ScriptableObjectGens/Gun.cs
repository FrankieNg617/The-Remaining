using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Gun", menuName="Gun")]
public class Gun : ScriptableObject
{
    public string name;
    public int damage;
    public int ammo;
    public int clipsize;
    public float fireRate;
    public float bloom;
    public float recoil;
    public float kickBack;
    public float aimSpeed;
    public float reloadTime;
    public GameObject prefab;

    private int stash; //current ammo
    private int clip; //current clip

    public void Initialize()
    {
        stash = ammo;
        clip = clipsize;
    }

    public bool FireBullet()
    {
        if(clip > 0)
        {
            clip -= 1;
            return true;
        }
        else return false;
    }

    public void Reload()
    {
        stash += clip;
        clip = Mathf.Min(clipsize, stash);
        stash -= clip;
    }

    public int GetStash(){ return stash; }
    public int GetClip(){ return clip; }

}
