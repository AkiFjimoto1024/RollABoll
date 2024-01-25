using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerRaycast : MonoBehaviour
{
	// �J�����ւ̃A�N�Z�X
	public Camera usedCamera;

	// �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
	public void OnEnable()
	{
		if (!usedCamera)
		{
			usedCamera = Camera.main;
		}
	}

	// ���t���[���Ăяo�����
	public void Update()
	{
		// mousePosition���烌�C���쐬
		Ray ray = usedCamera.ScreenPointToRay(Input.mousePosition);

		// Ray�ƈ�v�������`��
		Debug.DrawRay(ray.origin, ray.direction);
	}
}
