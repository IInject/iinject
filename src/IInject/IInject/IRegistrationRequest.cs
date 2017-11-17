using System;

namespace IInject
{
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
