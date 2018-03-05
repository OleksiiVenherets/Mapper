namespace AutoMapper
{
    /// <summary>
    /// Interface for Mapping objects
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Signature for method to maps properies from sourse object to new object TDestination type
        /// </summary>
        /// <typeparam name="TSourse">Generic type of the sourse object</typeparam>
        /// <typeparam name="TDestination">Generic type of the destination object</typeparam>
        /// <param name="sourseObject">Sourse object for mapping</param>
        /// <returns>New object with mapped properies</returns>
        TDestination Map<TSourse, TDestination>(TSourse sourseObject) where TSourse : class
            where TDestination : class, new();

        /// <summary>
        /// Signature for method to maps properties from Sourse object to Destination object
        /// </summary>
        /// <typeparam name="TSourse">Generic type of the sourse object</typeparam>
        /// <typeparam name="TDestination">Generic type of the destination object</typeparam>
        /// <param name="sourseObject">Sourse object for mapping</param>
        /// <param name="destinationObject">Destination object for mapping</param>
        /// <returns>Object with mapped properies</returns>
        TDestination Map<TSourse, TDestination>(TSourse sourseObject, TDestination destinationObject) where TSourse : class where TDestination : class;
    }
}