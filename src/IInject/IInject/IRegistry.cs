using System;

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
        IRegistrationResponse Add(IRegistrationRequest request);

        /// <summary>
        /// Validates that the request can be created returns the response.
        /// </summary>
        /// <param name="request">The <see cref="IResolutionRequest"/> to be constructed.</param>
        /// <returns></returns>
        IResolutionResponse Resolve(IResolutionRequest request);
    }

    /// <summary>
    /// Provides a registry for types to be resolved.
    /// </summary>
    public class Registry : IRegistry
    {
        /// <summary>
        /// Adds the <paramref name="request"/> to the registry for resolving.
        /// </summary>
        /// <param name="request">The <see cref="IRegistrationRequest"/> to be registered with this <see cref="IRegistry"/> instance.</param>
        /// <returns>The requested <see cref="IRegistrationResponse"/>.</returns>
        public IRegistrationResponse Add(IRegistrationRequest request)
        {
            throw new NotImplementedException();
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

    /// <summary>
    /// 
    /// </summary>
    public interface IResolutionRequest
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IResolutionResponse
    {
    }

    /// <summary>
    /// Represents a registration that can be resolved.
    /// </summary>
    public interface IRegistrationResponse
    {
    }

    /// <summary>
    /// Provides context around a type or collection of types registration.
    /// </summary>
    public interface IRegistrationRequest
    {
        /// <summary>
        /// A key identifying the current <see cref="IRegistrationRequest"/>.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// The <see cref="Type"/> used to resolve this particular dependency.
        /// </summary>
        Type From { get; }

        /// <summary>
        /// The implementation <see cref="Type"/> of the object that is returned when being resolved.
        /// </summary>
        Type To { get; }

        /// <summary>
        /// True, if the request should be precompiled; otherwise, false.
        /// </summary>
        bool Precompile { get; set; }
    }
}
