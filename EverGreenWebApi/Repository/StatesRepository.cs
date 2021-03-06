﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EverGreenWebApi.DBHelper;
using EverGreenWebApi.Interfaces;
using EverGreenWebApi.Models;

namespace EverGreenWebApi.Repository
{
    public class StatesRepository : IStatesRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StatesModel> GetAllStates()
        {           
            using (shamsweets_mobileappEntities context = new shamsweets_mobileappEntities())
            {
                var result = context.statemasters.OrderBy(s => s.StateName);
                var data = result.Select(s => new StatesModel()
                {
                    StateId = s.StateId,
                    StateName = s.StateName

                }).ToList();
                return data;
            }
        }
    }
}