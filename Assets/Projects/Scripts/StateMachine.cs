using System;
using System.Collections.Generic;

public class StateMachine : IDisposable
{
    private bool isEnable;
    private IState currentState;
    private Dictionary<Enum, IState> stateDictionary;
    private VoidState voidState;

    public StateMachine(bool isThrowException = false)
    {
        stateDictionary = new();
        voidState = new(isThrowException);
    }

    /// <summary>
    /// StateMachine�̗L�����
    /// </summary>
    public bool IsEnable => isEnable;

    /// <summary>
    /// ���݂̏��
    /// </summary>
    public IState CurrentState
    {
        get
        {
            if (isEnable)
            {
                return currentState;
            }

            return voidState;
        }
    }

    /// <summary>
    /// �V������Ԃ�o�^���܂�
    /// </summary>
    /// <param name="key">��Ԃ�o�^����񋓎q</param>
    /// <param name="value">��Ԃ̃C���X�^���X</param>
    /// <param name="isSingleton">�C���X�^���X���V���O���g���ɂ��܂�</param>
    public void Register(Enum key, IState value, bool isSingleton = false)
    {
        if (!(stateDictionary.TryAdd(key, value) && isSingleton))
        {
            stateDictionary[key] = value;
        }
        value.ChangeState = ChangeState;
    }

    /// <summary>
    /// ��Ԃ��X�V
    /// </summary>
    /// <param name="state">���ɍX�V������</param>
    private void ChangeState(Enum state)
    {
        if (currentState != null)
        {
            // ��Ԃ�����ΑO��̏I���������Ăяo��
            currentState.OnExit();
        }

        // �V������Ԃ�o�^
        currentState = stateDictionary[state];

        currentState.OnEnter();
    }

    /// <summary>
    /// StateMachine��L��������
    /// </summary>
    /// <param name="initalState">�����̏��</param>
    public void Enable(Enum initalState)
    {
        ChangeState(initalState);

        isEnable = true;
    }

    /// <summary>
    /// StateMachine�𖳌������܂�
    /// </summary>
    public void Disable()
    {
        if (isEnable)
        {
            // �I���������Ăяo���Ė�����
            currentState.OnExit();
            isEnable = false;
        }
    }

    void IDisposable.Dispose()
    {
        isEnable = false;
        currentState = null;
        stateDictionary.Clear();
        stateDictionary = null;
    }

    /// <summary>
    /// ���݂̏�Ԃ�string�^�ŕԂ��܂�
    /// </summary>
    /// <returns></returns>
    public string GetStateString() => currentState.ToString();

    private class VoidState : IState
    {
        private bool isThrowException;
        private Exception ex = new("��Ԃ͖����ł�");

        public VoidState(bool isThrowException)
        {
            this.isThrowException = isThrowException;
        }

        private Action<Enum> changeState;
        public Action<Enum> ChangeState { set => changeState = value; }

        void IState.OnEnter() { ThrowException(); }

        void IState.OnExit() { ThrowException(); }

        void IState.OnFixedUpdate() { ThrowException(); }

        void IState.OnUpdate() { ThrowException(); }

        private void ThrowException()
        {
            if (isThrowException)
            {
                throw ex;
            }
        }
    }
}