using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
	public GameObject vfxSource;
	public GameObject vfxSwitch;

	public void PlayVFX(Vector3 spawnPosition)
	{
		Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}

    // Note : Rasanya VFX ini bisa dibuat array gameobject agar tidak buat fungsi terus setiap tambah SFX
	public void PlayVFXSwitch(Vector3 spawnPosition)
	{
		Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
	}

}
