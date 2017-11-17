namespace IInject
{
    /// <summary>
    /// A single step in a series of strategies known as a pipeline.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Executes this strategy for the provided <see cref="IRegistrationRequest"/>.
        /// </summary>
        /// <param name="request"></param>
        void Execute(IRegistrationRequest request);
    }
}
