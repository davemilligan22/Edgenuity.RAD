using Edgenuity.RAD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Edgenuity.RAD.Domain.Logic
{
    public class ClassService
    {
        public ClassService()
        {
            // TODO: Inject data access, if needed
        }

        private Class GenerateFakeClass(long id)
        {
            Class c = new Class()
            {
                ClassID = id,
                ClassGUID = Guid.NewGuid(),
                ClassTitle = $"Test Class {id}", 
                OwnerID = 843842, 
                OrganizationID = 3423, 
                
            };
            return c;
        }

        public Class GetClass(int id)
        {
            Class c = GenerateFakeClass(id);
            return c;
        }

        public List<Class> GetClasses(int ownerId)
        {
            List<Class> classes = Enumerable.Range(1, 10).Select(i => GenerateFakeClass(i)).ToList();
            return classes;
        }

    }
}
