using System;

namespace IInject
{
    /// <summary>
    /// Provides a registry for types to be resolved.
    /// </summary>
    public class Registry : IRegistry
    {
        private readonly IStrategyPipeline _compilationPipeline;

        /// <summary>
        /// Initializes a new instance of this <see cref="Registry"/> with the provided <see cref="IStrategyPipeline"/>.
        /// </summary>
        /// <param name="compilationPipeline"></param>
        public Registry(IStrategyPipeline compilationPipeline)
        {
            _compilationPipeline = compilationPipeline;
        }

        /// <summary>
        /// Adds the <paramref name="request"/> to the registry for resolving.
        /// </summary>
        /// <param name="request">The <see cref="IRegistrationRequest"/> to be registered with this <see cref="IRegistry"/> instance.</param>
        /// <returns>The requested <see cref="IRegistrationResponse"/>.</returns>
        public IRegistrationResponse Register(IRegistrationRequest request)
        {
            if (request.Precompile)
            {
                _compilationPipeline.Run(request);
            }

            return null;
        }

        /// <summary>
        /// Validates that the request can be created returns the response.
        /// </summary>
        /// <param name="request">The <see cref="IResolutionRequest"/> to be constructed.</param>
        /// <returns></returns>
        public IResolutionResponse Resolve(IResolutionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
