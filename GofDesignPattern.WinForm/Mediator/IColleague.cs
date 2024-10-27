namespace GofDesignPattern.WinForm.Mediator
{
    public interface IColleague
    {
        /// <summary>
        /// Mediatorを設定する
        /// </summary>
        /// <param name="mediator"></param>
        void SetMediator(IMediator mediator);

        /// <summary>
        /// Mediatorから有効無効を指示される
        /// </summary>
        /// <param name="enabled"></param>
        void SetColleagueEnabled(bool enabled);
    }
}
