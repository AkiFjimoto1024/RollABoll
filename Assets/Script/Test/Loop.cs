using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        //ForeachLoop();
        //WhileLoop();
        DoWhileLoop();
    }
    void ForLoop()
    {
        /* for(������(Initialize);����(Condition);�X�V(Update))
        * ������: for���[�v�̃��[�v���Ǘ����邽�߂̕ϐ��Ȃǂ�����������
        * ����: �����ɏ�����Ă��������true�̏ꍇ�Afor�ȉ��̃R�[�h�����s����
        * �X�V: ������1�Z�b�g�I�������ɁA���[�v���Ǘ����邽�߂̕ϐ��Ȃǂ��X�V����
        */
        Debug.Log("1~100�܂Ő����܂�");
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("for���[�v���I�����܂�");

        // �p�^�[��2
        Debug.Log("1~100�̊Ԃ̋����𐔂��܂�");
        for (int counter = 2; counter <= 100; counter += 2)
        {
            Debug.Log(counter);
        }
        Debug.Log("for���[�v���I�����܂�");
    }
    void WhileLoop()
    {
        /* while(����): ������true�ł���ꍇ�A�������J��Ԃ�
        */
        Debug.Log("while���[�v��1~100�܂Ő����܂�");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("while���[�v���I�����܂�");
    }
    void DoWhileLoop()
    {
        /* do{}while(����);: �ŏ��Ɉ�x�K���������s���B���̌�A������true�ł���ꍇ�A�������J��Ԃ�
        */
        int counter = 200;
        Debug.Log("do while���[�v��1~100�܂Ő����܂�");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do while���[�v���I�����܂�");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
