using System.Collections;
using System.Collections.Generic;

namespace IInject
{
    /// <summary>
    /// A series of <see cref="IStrategy"/>s that can manipulate the registration and resolution of a type.
    /// </summary>
    public interface IStrategyPipeline : IEnumerable<IStrategy>
    {
        /// <summary>
        /// Adds the <see cref="IStrategy" /> to this <see cref="IStrategyPipeline" />.
        /// </summary>
        /// <param name="strategy"></param>
        void AttachStrategy(IStrategy strategy);

        /// <summary>
        /// Begins the execution of this <see cref="IStrategyPipeline" />
        /// for the provided <see cref="IRegistrationRequest"/>.
        /// </summary>
        /// <param name="request"></param>
        void Run(IRegistrationRequest request);
    }


    /// <summary>
    /// 
    /// </summary>
    public class StrategyPipeline : IStrategyPipeline
    {
        private readonly ICollection<IStrategy> _strategies = new List<IStrategy>();

        /// <summary>
        /// Initializes a new instance of <see cref="StrategyPipeline"/>.
        /// </summary>
        public StrategyPipeline()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerator<IStrategy> GetEnumerator() => _strategies.GetEnumerator();

        /// <summary>
        /// 
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// 
        /// </summary>
        public void AttachStrategy(IStrategy strategy) => _strategies.Add(strategy);

        /// <summary>
        /// 
        /// </summary>
        public void Run(IRegistrationRequest request)
        {
            foreach (var strategy in _strategies) {
                strategy.Execute(request);
            }
        }
    }
}
