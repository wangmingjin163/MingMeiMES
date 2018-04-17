﻿using System;
using System.Data;
using System.Collections.Generic;
using FTDataAccess.Model;
namespace FTDataAccess.BLL
{
    /// <summary>
    /// 包装尺寸定义
    /// </summary>
    public partial class ProductPacsizeDefBll
    {
        private readonly FTDataAccess.DAL.ProductPacsizeDefDal dal = new FTDataAccess.DAL.ProductPacsizeDefDal();
        public ProductPacsizeDefBll()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string packageSize)
        {
            return dal.Exists(packageSize);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FTDataAccess.Model.ProductPacsizeDefModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FTDataAccess.Model.ProductPacsizeDefModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string packageSize)
        {

            return dal.Delete(packageSize);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string packageSizelist)
        {
            return dal.DeleteList(packageSizelist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FTDataAccess.Model.ProductPacsizeDefModel GetModel(string packageSize)
        {

            return dal.GetModel(packageSize);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FTDataAccess.Model.ProductPacsizeDefModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FTDataAccess.Model.ProductPacsizeDefModel> DataTableToList(DataTable dt)
        {
            List<FTDataAccess.Model.ProductPacsizeDefModel> modelList = new List<FTDataAccess.Model.ProductPacsizeDefModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FTDataAccess.Model.ProductPacsizeDefModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

