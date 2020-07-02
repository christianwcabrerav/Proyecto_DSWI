using Proyecto_Ecom_v01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Ecom_v01.Repositorio
{
    public class UnidadDeTrabajoGenerico : IDisposable
    {
        private dbMyOnlineShoppingEntities DBEntity = new dbMyOnlineShoppingEntities();
        public IRepositorio<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType : class
        {
            return new RepositorioGenerico<Tbl_EntityType>(DBEntity);
        }

        public void SaveChanges()
        {
            DBEntity.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DBEntity.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

    }
}
