﻿using Microsoft.EntityFrameworkCore;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class AutorizacionRepository : GenericRepository<Autorizacion>, IAutorizacionRepository
    {
        public AutorizacionRepository(VeterinariaContext _context) : base(_context)
        {


        }

        public async Task<IEnumerable<Autorizacion>> GetAutorizacionesByMascotaIdAsync(int mascotaId)
        {
            return await _context.Set<Autorizacion>()
                                 .Where(a => a.MascotaId == mascotaId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Autorizacion>> GetAutorizacionesByVeterinariaIdAsync(int veterinariaId)
        {
            return await _context.Set<Autorizacion>()
                                 .Include(a => a.Mascota)
                                 .Where(a => a.VeterinariaId == veterinariaId)
                                 .ToListAsync();
        }

        public async Task<Autorizacion> GetAutorizacionByMascotaIdAndVeterinariaIdAsync(GetAutorizacionDTO getAutorizacionDTO)
        {
            return await _context.Set<Autorizacion>()
                                 .SingleOrDefaultAsync(a => a.MascotaId == getAutorizacionDTO.MascotaId && a.VeterinariaId == getAutorizacionDTO.VeterinariaId);
        }




    }
}
