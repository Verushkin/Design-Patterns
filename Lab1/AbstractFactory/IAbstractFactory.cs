namespace AbstractFactory
{
    internal interface IAbstractFactory
    {
        IChair CreateChair();
        IBed CreateBed();
    }
    internal interface IChair
    {
        void Fold();
        void Unfold();
    }
    internal interface IBed
    {
        void Cover();
        void Uncover();

    }
}
