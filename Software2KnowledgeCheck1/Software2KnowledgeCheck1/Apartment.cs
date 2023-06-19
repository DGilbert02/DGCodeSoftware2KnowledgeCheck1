using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }

        public bool HasParking { get; set; }
    }
    internal class ApartmentMethod {
        public void CreateApartment(Apartment apartment)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = BuildingMethod.ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                BuildingList.Buildings.Add(apartment);
            }
        }
    }
    
}
