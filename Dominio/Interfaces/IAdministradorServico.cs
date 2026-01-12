using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Enuns;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;


public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    List<Administrador> Todos(int? pagina);
    Administrador? BuscaPorId(int id);
    //Administrador Alterar(Administrador administrador);
    //Administrador Remover(Administrador administrador);
}