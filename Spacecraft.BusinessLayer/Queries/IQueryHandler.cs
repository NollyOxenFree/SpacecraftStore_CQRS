namespace Spacecraft.BusinessLayer.Queries
{
    internal interface IQueryHandler<T>
        where T : class, IQuery
    {
        public void Handle(T query);
    }
}
