namespace GofDesignPattern.WinForm.Mediator
{
    public interface IMediator
    {
        /// <summary>
        /// Colleagueたちを生成する
        /// </summary>
        void CreateColleagues();

        /// <summary>
        /// Colleagueの状態が変化したときに呼ばれる
        /// </summary>
        void ColleagueChanged();
    }
}