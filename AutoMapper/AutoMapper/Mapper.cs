using System;
using System.Reflection;

namespace AutoMapper
{
    /// <summary>
    /// Class which implemented Interface IMapper. Contains methods for mapping two objects
    /// </summary>
    public class Mapper: IMapper 
    {
        /// <summary>
        /// Maps properies from sourse object to new object TDestination type
        /// </summary>
        /// <typeparam name="TSourse">Generic type of the sourse object</typeparam>
        /// <typeparam name="TDestination">Generic type of the destination object</typeparam>
        /// <param name="sourseObject">Sourse object for mapping</param>
        /// <returns>New object with mapped properies</returns>
        public TDestination Map<TSourse, TDestination>(TSourse sourseObject) where TSourse : class where TDestination : class, new ()
        {
            if (sourseObject == null)
                throw new ObjectNullException("The sourse object is not intanced");
            var destinationObject = new TDestination();
            return CreateMap(sourseObject, destinationObject);
        }
        /// <summary>
        /// Maps properties from Sourse object to Destination object
        /// </summary>
        /// <typeparam name="TSourse">Generic type of the sourse object</typeparam>
        /// <typeparam name="TDestination">Generic type of the destination object</typeparam>
        /// <param name="sourseObject">Sourse object for mapping</param>
        /// <param name="destinationObject">Destination object for mapping</param>
        /// <returns>Object with mapped properies</returns>
        public TDestination Map<TSourse, TDestination>(TSourse sourseObject, TDestination destinationObject) where TSourse : class where TDestination : class
        {
            if (sourseObject == null)
                throw new ObjectNullException("The sourse object is not intanced");
            if (destinationObject == null)
                throw new ObjectNullException("The destination object is not intanced");
            return CreateMap(sourseObject, destinationObject);
        }

        /// <summary>
        /// Method which contains mapping logic of two objects
        /// </summary>
        /// <typeparam name="TSourse">Generic type of the sourse object</typeparam>
        /// <typeparam name="TDestination">Generic type of the destination object</typeparam>
        /// <param name="sourseObject">Sourse object for mapping</param>
        /// <param name="destinationObject">Destination object for mapping</param>
        /// <returns>Object with mapped properies</returns>
        private TDestination CreateMap<TSourse, TDestination>(TSourse sourseObject, TDestination destinationObject)
        {
            PropertyInfo[] sourseProperties;
            try
            {
                sourseProperties = sourseObject.GetType()
                .GetProperties();
            }
            
            catch(NullReferenceException)
            {
                throw new EmptyObjectException("Sourse object have empty properies");
            }
            
            var destinationProperties = destinationObject.GetType()
                .GetProperties();

            foreach (var sourseProperty in sourseProperties)
            {
                foreach (var destinationProperty in destinationProperties)
                {
                    if (destinationProperty.PropertyType.Namespace == "System")
                    {
                        if (sourseProperty.PropertyType.Namespace != "System")
                        {
                            destinationObject = CreateMap(sourseProperty.GetValue(sourseObject), destinationObject);
                        }

                        if (sourseProperty.Name.Equals(destinationProperty.Name, StringComparison.OrdinalIgnoreCase)
                            && sourseProperty.PropertyType == destinationProperty.PropertyType)
                        {
                            destinationProperty.SetValue(destinationObject, sourseProperty.GetValue(sourseObject));
                        }
                    }
                    else
                    {
                        destinationProperty.SetValue(destinationObject, CreateMap(sourseObject, destinationProperty.GetValue(destinationObject)));
                    }                   
                }
            }
            return destinationObject;
        }
    }
}
