namespace GofDesignPattern.WinForm.State
{
    public interface IContext
    {
        /// <summary>
        /// 時刻の設定
        /// </summary>
        /// <param name="hour"></param>
        void SetClock(int hour);

        /// <summary>
        /// 状態変化
        /// </summary>
        /// <param name="state"></param>
        void ChangeState(IState state);

        /// <summary>
        /// 警備センター警備員呼び出し
        /// </summary>
        /// <param name="msg"></param>
        void CallSecurityCenter(string msg);

        /// <summary>
        /// 警備センター記録
        /// </summary>
        /// <param name="msg"></param>
        void RecordLog(string msg);
    }
}
