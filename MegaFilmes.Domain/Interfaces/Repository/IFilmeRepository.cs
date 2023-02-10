﻿using MegaFilmes.Domain.Entities;

namespace MegaFilmes.Domain.Interfaces.Repository;

public interface IFilmeRepository
{
    Task<ICollection<Filme>> GetAllAsync();
    Task<Filme?> GetByIdAsync(int id);
    Task<Filme> CreateAsync(Filme filme);
    Task<Filme> UpdateAsync(Filme filme);
    Task DeleteAsync(Filme filme);
    Task<Filme?> GetByGender(string genero);
    Task<List<Filme>> GetByDirector(string diretor);
    Task<List<Filme>> GetByName(string nome);
}
