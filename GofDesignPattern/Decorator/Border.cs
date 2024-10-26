namespace GofDesignPattern.Decorator
{
    public abstract class Border : Display
    {
        /// <summary>
        /// この飾り枠がくるんでいる「中身」を表す
        /// </summary>
        protected Display display;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// インスタンス生成時に「中身」を引数で指定
        /// </remarks>
        /// <param name="display"></param>
        protected Border(Display display)
        {
            this.display = display;
        }
    }
}
