namespace CommandDP.Interface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
