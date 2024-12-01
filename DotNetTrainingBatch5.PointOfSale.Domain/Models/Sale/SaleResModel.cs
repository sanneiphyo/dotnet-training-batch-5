﻿using DotNetTrainingBatch5.PointOfSale.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch5.PointOfSale.Domain.Models.Sale
{
    public class SaleResModel
    {
        public ExtendedSale Sale { get; set; }
    }

    public class ExtendedSale : TblSale
    {
        public List<ExtendedSaleDetail>? SaleDetails { get; set; }
    }
    public class ExtendedSaleDetail : TblSaleDetail
    {
        public List<TblProduct>? Products { get; set; }
    }
}
