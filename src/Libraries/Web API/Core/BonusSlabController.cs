using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Core
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Bonus Slabs.
    /// </summary>
    [RoutePrefix("api/v1.5/core/bonus-slab")]
    public class BonusSlabController : ApiController
    {
        /// <summary>
        ///     The BonusSlab data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.BonusSlab BonusSlabContext;

        public BonusSlabController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.BonusSlabContext = new MixERP.Net.Schemas.Core.Data.BonusSlab
            {
                Catalog = this.Catalog,
                LoginId = this.LoginId
            };
        }

        public long LoginId { get; }
        public int UserId { get; private set; }
        public int OfficeId { get; private set; }
        public string Catalog { get; }

        /// <summary>
        ///     Counts the number of bonus slabs.
        /// </summary>
        /// <returns>Returns the count of the bonus slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/bonus-slab/count")]
        public long Count()
        {
            try
            {
                return this.BonusSlabContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of bonus slab.
        /// </summary>
        /// <param name="bonusSlabId">Enter BonusSlabId to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{bonusSlabId}")]
        [Route("~/api/core/bonus-slab/{bonusSlabId}")]
        public MixERP.Net.Entities.Core.BonusSlab Get(int bonusSlabId)
        {
            try
            {
                return this.BonusSlabContext.Get(bonusSlabId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        [AcceptVerbs("GET", "HEAD")]
        [Route("get")]
        [Route("~/api/core/bonus-slab/get")]
        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> Get([FromUri] int[] bonusSlabIds)
        {
            try
            {
                return this.BonusSlabContext.Get(bonusSlabIds);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 bonus slabs on each page, sorted by the property BonusSlabId.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/bonus-slab")]
        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPagedResult()
        {
            try
            {
                return this.BonusSlabContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 bonus slabs on each page, sorted by the property BonusSlabId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/bonus-slab/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.BonusSlabContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a filtered and paginated collection containing 25 bonus slabs on each page, sorted by the property BonusSlabId.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/bonus-slab/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.BonusSlabContext.GetWhere(pageNumber, f);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfield is a lightweight key/value collection of bonus slabs.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of bonus slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/bonus-slab/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.BonusSlabContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     A custom field is a user defined field for bonus slabs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of bonus slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/bonus-slab/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.BonusSlabContext.GetCustomFields(null);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     A custom field is a user defined field for bonus slabs.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of bonus slabs.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/bonus-slab/custom-fields/{resourceId}")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            try
            {
                return this.BonusSlabContext.GetCustomFields(resourceId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds or edits your instance of BonusSlab class.
        /// </summary>
        /// <param name="bonusSlab">Your instance of bonus slabs class to add or edit.</param>
        [AcceptVerbs("PUT")]
        [Route("add-or-edit")]
        [Route("~/api/core/bonus-slab/add-or-edit")]
        public void AddOrEdit([FromBody]MixERP.Net.Entities.Core.BonusSlab bonusSlab)
        {
            if (bonusSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.BonusSlabContext.AddOrEdit(bonusSlab);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of BonusSlab class.
        /// </summary>
        /// <param name="bonusSlab">Your instance of bonus slabs class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{bonusSlab}")]
        [Route("~/api/core/bonus-slab/add/{bonusSlab}")]
        public void Add(MixERP.Net.Entities.Core.BonusSlab bonusSlab)
        {
            if (bonusSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.BonusSlabContext.Add(bonusSlab);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of BonusSlab class.
        /// </summary>
        /// <param name="bonusSlab">Your instance of BonusSlab class to edit.</param>
        /// <param name="bonusSlabId">Enter the value for BonusSlabId in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{bonusSlabId}")]
        [Route("~/api/core/bonus-slab/edit/{bonusSlabId}")]
        public void Edit(int bonusSlabId, [FromBody] MixERP.Net.Entities.Core.BonusSlab bonusSlab)
        {
            if (bonusSlab == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.BonusSlabContext.Update(bonusSlab, bonusSlabId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of BonusSlab class via BonusSlabId.
        /// </summary>
        /// <param name="bonusSlabId">Enter the value for BonusSlabId in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{bonusSlabId}")]
        [Route("~/api/core/bonus-slab/delete/{bonusSlabId}")]
        public void Delete(int bonusSlabId)
        {
            try
            {
                this.BonusSlabContext.Delete(bonusSlabId);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }


    }
}