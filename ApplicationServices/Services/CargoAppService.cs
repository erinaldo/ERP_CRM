using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class CargoAppService : AppServiceBase<CARGO>, ICargoAppService
    {
        private readonly ICargoService _baseService;

        public CargoAppService(ICargoService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<CARGO> GetAllItens(Int32 idAss)
        {
            List<CARGO> lista = _baseService.GetAllItens(idAss);
            return lista;
        }

        public List<CARGO> GetAllItensAdm(Int32 idAss)
        {
            List<CARGO> lista = _baseService.GetAllItensAdm(idAss);
            return lista;
        }

        public CARGO GetItemById(Int32 id)
        {
            CARGO item = _baseService.GetItemById(id);
            return item;
        }

        public CARGO CheckExist(CARGO conta, Int32 idAss)
        {
            CARGO item = _baseService.CheckExist(conta, idAss);
            return item;
        }

        public Int32 ValidateCreate(CARGO item, USUARIO usuario)
        {
            try
            {
                // Verifica existencia pr�via
                if (_baseService.CheckExist(item, usuario.ASSI_CD_ID) != null)
                {
                    return 1;
                }

                // Completa objeto
                item.CARG_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "AddCARG",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CARGO>(item)
                };

                // Persiste
                Int32 volta = _baseService.Create(item);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public Int32 ValidateEdit(CARGO item, CARGO itemAntes, USUARIO usuario)
        {
            try
            {
                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "EditCARG",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CARGO>(item),
                    LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<CARGO>(itemAntes)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateDelete(CARGO item, USUARIO usuario)
        {
            try
            {
                // Checa integridade
                if (item.USUARIO.Count > 0)
                {
                    return 1;
                }

                // Acerta campos
                item.CARG_IN_ATIVO = 0;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "DelCARG",
                    LOG_TX_REGISTRO = item.CARG_NM_NOME
                };

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateReativar(CARGO item, USUARIO usuario)
        {
            try
            {
                // Verifica integridade referencial

                // Acerta campos
                item.CARG_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "ReatCARG",
                    LOG_TX_REGISTRO = item.CARG_NM_NOME
                };

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
