using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem dust;

    public void PlayDust()
    {
           dust.Play(); 
  }
}
