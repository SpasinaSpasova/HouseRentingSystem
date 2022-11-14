﻿using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseHomeModel>> LastThreeHouses();
        Task<IEnumerable<HouseCategoryModel>> AllCategories();
        Task<bool> CategoryExists(int categoryId);
        Task<int> Create(HouseFormModel model, int agentId);
    }
}
