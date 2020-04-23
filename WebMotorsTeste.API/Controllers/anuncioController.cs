using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using WebMotorsTeste.Core.Repository;
using WebMotorsTeste.Data;
using WebMotorsTeste.Data.Entities;

namespace WebMotorsTeste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class anuncioController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Anuncio> _repositorioAnuncio;

        public anuncioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorioAnuncio = _unitOfWork.GetRepository<Anuncio>();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                JArray json = new JArray();

                _repositorioAnuncio.GetAll().ToList().ForEach(anuncio =>
                {
                    JObject obj =
                       new JObject(
                           new JProperty("ID", anuncio.ID),
                           new JProperty("marca", anuncio.marca),
                           new JProperty("modelo", anuncio.modelo),
                           new JProperty("versao", anuncio.versao),
                           new JProperty("ano", anuncio.ano),
                           new JProperty("quilometragem", anuncio.quilometragem),
                           new JProperty("observacao", anuncio.observacao));

                    json.Add(obj);
                });

                return Ok(json);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
        }

        [HttpGet]
        [Route("{ID}")]
        public IActionResult Get(int ID)
        {
            try
            {
                var anuncio = _repositorioAnuncio.Get(x => x.ID.Equals(ID)).FirstOrDefault();

                if (anuncio != null)
                {
                    return Ok(
                        new JObject(
                           new JProperty("ID", anuncio.ID),
                           new JProperty("marca", anuncio.marca),
                           new JProperty("modelo", anuncio.modelo),
                           new JProperty("versao", anuncio.versao),
                           new JProperty("ano", anuncio.ano),
                           new JProperty("quilometragem", anuncio.quilometragem),
                           new JProperty("observacao", anuncio.observacao))
                    );
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Anuncio request)
        {
            using (var transaction = _repositorioAnuncio.BeginTransaction())
            {
                try
                {
                    _repositorioAnuncio.Save(request);

                    transaction.Commit();
                    return Ok();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return StatusCode(500, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                }
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Anuncio request)
        {
            using (var transaction = _repositorioAnuncio.BeginTransaction())
            {
                try
                {
                    var cartao = _repositorioAnuncio.GetNoTracking(x => x.ID.Equals(request.ID)).FirstOrDefault();

                    if (cartao != null)
                    {
                        _repositorioAnuncio.Save(request);

                        transaction.Commit();
                    }
                    else
                        return NotFound();


                    return Ok();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return StatusCode(500, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                }
            }
        }

        [HttpDelete]
        [Route("{ID}")]
        public IActionResult Delete(int ID)
        {
            using (var transaction = _repositorioAnuncio.BeginTransaction())
            {
                try
                {
                    var cartao = _repositorioAnuncio.Get(x => x.ID.Equals(ID)).FirstOrDefault();

                    if (cartao != null)
                    {
                        _repositorioAnuncio.Delete(cartao);

                        transaction.Commit();
                    }
                    else
                        return NotFound();

                    return Ok();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return StatusCode(500, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                }
            }
        }

    }
}