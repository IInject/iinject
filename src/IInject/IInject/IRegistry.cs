using System.Collections.Concurrent;

namespace IInject
{
    /// <summary>
    /// When implemented in a derived class, provides a registry for types to be resolved.
    /// </summary>
    public interface IRegistry
    {
        /// <summary>
        /// Adds the <paramref name="request"/> to the registry for resolving.
        /// </summary>
        /// <param name="request">The <see cref="IRegistrationRequest"/> to be registered with this <see cref="IRegistry"/> instance.</param>
        /// <returns>The requested <see cref="IRegistrationResponse"/>.</returns>
        IRegistrationResponse Register(IRegistrationRequest request);

        /// <summary>
        /// Validates that the request can be created returns the response.
        /// </summary>
        /// <param name="request">The <see cref="IResolutionRequest"/> to be constructed.</param>
        /// <returns></returns>
        IResolutionResponse Resolve(IResolutionRequest request);
    }
}
