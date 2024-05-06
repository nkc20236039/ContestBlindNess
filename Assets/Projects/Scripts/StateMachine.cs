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
    /// StateMachineの有効状態
    /// </summary>
    public bool IsEnable => isEnable;

    /// <summary>
    /// 現在の状態
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
    /// 新しい状態を登録します
    /// </summary>
    /// <param name="key">状態を登録する列挙子</param>
    /// <param name="value">状態のインスタンス</param>
    /// <param name="isSingleton">インスタンスをシングルトンにします</param>
    public void Register(Enum key, IState value, bool isSingleton = false)
    {
        if (!(stateDictionary.TryAdd(key, value) && isSingleton))
        {
            stateDictionary[key] = value;
        }
        value.ChangeState = ChangeState;
    }

    /// <summary>
    /// 状態を更新
    /// </summary>
    /// <param name="state">次に更新する状態</param>
    private void ChangeState(Enum state)
    {
        if (currentState != null)
        {
            // 状態があれば前回の終了処理を呼び出し
            currentState.OnExit();
        }

        // 新しい状態を登録
        currentState = stateDictionary[state];

        currentState.OnEnter();
    }

    /// <summary>
    /// StateMachineを有効化する
    /// </summary>
    /// <param name="initalState">初期の状態</param>
    public void Enable(Enum initalState)
    {
        ChangeState(initalState);

        isEnable = true;
    }

    /// <summary>
    /// StateMachineを無効化します
    /// </summary>
    public void Disable()
    {
        if (isEnable)
        {
            // 終了処理を呼び出して無効化
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
    /// 現在の状態をstring型で返します
    /// </summary>
    /// <returns></returns>
    public string GetStateString() => currentState.ToString();

    private class VoidState : IState
    {
        private bool isThrowException;
        private Exception ex = new("状態は無効です");

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