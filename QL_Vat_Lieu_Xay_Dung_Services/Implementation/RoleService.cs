﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;

namespace QL_Vat_Lieu_Xay_Dung_Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IRepository<Function, string> _functionRepository;
        private readonly IRepository<Permission, int> _permissionRepository;
        //private IRepository<Announcement, string> _announRepository;
        //private IRepository<AnnouncementUser, int> _announUserRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(RoleManager<AppRole> roleManager, IUnitOfWork unitOfWork, IRepository<Function, string> functionRepository, IRepository<Permission, int> permissionRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _functionRepository = functionRepository;
            _permissionRepository = permissionRepository;
            _mapper = mapper;
            //_announRepository = announRepository;
            //_announUserRepository = announUserRepository;
        }

        //public async Task<bool> AddAsync(AnnouncementViewModel announcementViewModel,
        //    List<AnnouncementUserViewModel> announcementUsers, AppRoleViewModel roleViewModel)
        //{
        //    var role = new AppRole()
        //    {
        //        Name = roleViewModel.Name,
        //        Description = roleViewModel.Description
        //    };
        //    var result = await _roleManager.CreateAsync(role);
        //    var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
        //    _announRepository.Add(announcement);
        //    foreach (var userViewModel in announcementUsers)
        //    {
        //        var user = _mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(userViewModel);
        //        _announUserRepository.Add(user);
        //    }
        //    _unitOfWork.Commit();
        //    return result.Succeeded;
        //}

        public Task<bool> CheckPermission(string functionId, string action, string[] roles)
        {
            var functions = _functionRepository.FindAll();
            var permissions = _permissionRepository.FindAll();
            var query = from f in functions
                        join p in permissions on f.Id equals p.FunctionId
                        join r in _roleManager.Roles on p.RoleId equals r.Id
                        where roles.Contains(r.Name) && f.Id == functionId
                        && ((p.CanCreate && action == "Create")
                        || (p.CanUpdate && action == "Update")
                        || (p.CanDelete && action == "Delete")
                        || (p.CanRead && action == "Read"))
                        select p;
            return query.AnyAsync();
        }

        public async Task<bool> AddAsync(AppRoleViewModel roleViewModel)
        {
            var role = new AppRole()
            {
                Name = roleViewModel.Name,
                Description = roleViewModel.Description
            };
            var result = await _roleManager.CreateAsync(role);
            return result.Succeeded;
        }

        public async Task DeleteAsync(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(role);
        }

        public async Task<List<AppRoleViewModel>> GetAllAsync()
        {
            return await _mapper.ProjectTo<AppRoleViewModel>(_roleManager.Roles).ToListAsync();
        }

        public PagedResult<AppRoleViewModel> GetAllPagingAsync(string keyword, int page, int pageSize)
        {
            var query = _roleManager.Roles;
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword)
                || x.Description.Contains(keyword));

            var totalRow = query.Count();
            query = query.Skip((page - 1) * pageSize)
               .Take(pageSize);

            var data = _mapper.ProjectTo<AppRoleViewModel>(query).ToList();
            var paginationSet = new PagedResult<AppRoleViewModel>()
            {
                ResultList = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public async Task<AppRoleViewModel> GetById(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            return _mapper.Map<AppRole, AppRoleViewModel>(role);
        }

        public async Task<AppRoleViewModel> GetByName(string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            return _mapper.Map<AppRole, AppRoleViewModel>(role);
        }

        public List<PermissionViewModel> GetListFunctionWithRole(Guid roleId)
        {
            var functions = _functionRepository.FindAll();
            var permissions = _permissionRepository.FindAll();

            var query = from f in functions
                        join p in permissions on f.Id equals p.FunctionId into fp
                        from p in fp.DefaultIfEmpty()
                        where p != null && p.RoleId == roleId
                        select new PermissionViewModel()
                        {
                            RoleId = roleId,
                            FunctionId = f.Id,
                            CanCreate = p != null && p.CanCreate,
                            CanDelete = p != null && p.CanDelete,
                            CanRead = p != null && p.CanRead,
                            CanUpdate = p != null && p.CanUpdate
                        };
            return query.ToList();
        }
        public IQueryable<FunctionViewModel> GetListFunctionWithRole_Function(Guid roleId)
        {
            var functions = _functionRepository.FindAll();
            var permissions = _permissionRepository.FindAll();

            var query = from f in functions
                        join p in permissions on f.Id equals p.FunctionId into fp
                        from p in fp.DefaultIfEmpty()
                        where p != null && p.RoleId == roleId && p.CanRead
                        select new FunctionViewModel()
                        {
                            Id = f.Id,
                            IconCss = f.IconCss,
                            Name = f.Name,
                            ParentId = f.ParentId,
                            SortOrder = f.SortOrder,
                            Status = f.Status,
                            URL = f.URL
                        };
            return query;
        }

        public void SavePermission(List<PermissionViewModel> permissionViewModels, Guid roleId)
        {
            var permissions = _mapper.Map<List<PermissionViewModel>, List<Permission>>(permissionViewModels);
            var oldPermission = _permissionRepository.FindAll().Where(x => x.RoleId == roleId).ToList();
            if (oldPermission.Count > 0)
            {
                _permissionRepository.RemoveMultiple(oldPermission);
            }
            foreach (var permission in permissions)
            {
                _permissionRepository.Add(permission);
            }
            _unitOfWork.Commit();
        }

        public async Task UpdateAsync(AppRoleViewModel roleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(roleViewModel.Id.ToString());
            role.Description = roleViewModel.Description;
            role.Name = roleViewModel.Name;
            await _roleManager.UpdateAsync(role);
        }
    }
}