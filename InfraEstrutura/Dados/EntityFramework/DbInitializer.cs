using System.Data.Entity;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework
{
    public class DbInitializer : CreateDatabaseIfNotExists<PeladaFCContexto>
    {
        protected override void Seed(PeladaFCContexto context)
        {
            
        }
    }
}