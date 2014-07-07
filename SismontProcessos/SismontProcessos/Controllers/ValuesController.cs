using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Breeze.ContextProvider.EF6;
using Xerife.Data;

namespace SismontProcessos.Controllers
{
    public class ValuesController : ApiController
    {
        protected readonly xerifeEntities _context;
        internal ValuesController()
        {
            _context = new xerifeEntities();
        }

        protected virtual IQueryable<T> Get<T>(Dictionary<string, object> paramenters) where T : class
        {
            return _context.GetObjects<T>(paramenters);
        }

        protected virtual IQueryable<T> Get<T>() where T : class
        {
            return _context.GetObjects<T>();
        }

        protected virtual void DoPost<T>(T entity) where T : class
        {
            _context.AddToObject<T>(entity);
        }

        protected virtual void DoDelete<T>(T entity) where T : class
        {
            _context.RemoveObject<T>(entity);
        }

        /// <summary>
        /// Atualiza objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">Objeto base</param>
        /// <param name="entity2">Objeto que será atualizado</param>
        protected virtual void DoUpdate<T>(T entity,T entity2) where T : class
        {
            _context.UpdateObject<T>(entity,entity2);
        }
    }
}
