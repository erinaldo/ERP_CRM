﻿using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesServices.Interfaces.Repositories
{
    public interface IOrdemServicoRepository: IRepositoryBase<ORDEM_SERVICO>
    {
        ORDEM_SERVICO CheckExist(ORDEM_SERVICO item);
        ORDEM_SERVICO GetItemById(Int32 id);
        List<ORDEM_SERVICO> GetAllItens();
        List<ORDEM_SERVICO> GetAllItensAdm();
        List<ORDEM_SERVICO> ExecuteFilter(Int32? catOS, Int32? idClie, Int32? idUsu, DateTime? dtCriacao, Int32? status, Int32? idDept, Int32? idServ, Int32? idProd, Int32? idAten);
    }
}
