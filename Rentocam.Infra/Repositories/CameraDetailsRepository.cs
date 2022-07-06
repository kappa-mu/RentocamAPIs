using Rentocam.Domain;
using Rentocam.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentocam.Infra.Repositories
{
    public class CameraDetailsRepository : GenericRepository<CameraDetails>
    {
        public CameraDetailsRepository(RentocamContext context) : base(context)
        {
                
        }

        public override CameraDetails Update(CameraDetails entity)
        {
            var cameraDetails = context.CameraDetails.Single(cd => cd.Id == entity.Id);
            cameraDetails.Manufacturer = entity.Manufacturer;
            cameraDetails.YearOfManufacture = entity.YearOfManufacture;
            cameraDetails.ModelName = entity.ModelName;
            cameraDetails.Color =  entity.Color;
            cameraDetails.Weight = entity.Weight;
            return base.Update(cameraDetails);
        }
    }
}
