using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
	public GameObject vfxSource;

	public void PlayVFX(Vector3 spawnPosition)
	{
		Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}
}
