namespace CarCollection.WebApi.Lib.Commands
{
    public interface ICommand<in TParam>
    {
        void Execute(TParam param);
    }
}
