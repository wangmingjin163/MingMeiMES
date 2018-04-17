﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MTDBAccess.DAL
{

    /// <summary>
    /// 数据访问类:db
    /// </summary>
    public partial class dbDAL
    {
        public dbDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string 测试时间, string 二维码, string 正螺丝数据, string 反螺丝数据)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from db");
            strSql.Append(" where 测试时间=@测试时间 and 二维码=@二维码 and 正螺丝数据=@正螺丝数据 and 反螺丝数据=@反螺丝数据 ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@测试时间", OleDbType.VarChar,255),
					new OleDbParameter("@二维码", OleDbType.VarChar,255),
					new OleDbParameter("@正螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@反螺丝数据", OleDbType.VarChar,255)			};
            parameters[0].Value = 测试时间;
            parameters[1].Value = 二维码;
            parameters[2].Value = 正螺丝数据;
            parameters[3].Value = 反螺丝数据;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MTDBAccess.Model.dbModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into db(");
            strSql.Append("测试时间,二维码,正螺丝数据,反螺丝数据)");
            strSql.Append(" values (");
            strSql.Append("@测试时间,@二维码,@正螺丝数据,@反螺丝数据)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@测试时间", OleDbType.VarChar,255),
					new OleDbParameter("@二维码", OleDbType.VarChar,255),
					new OleDbParameter("@正螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@反螺丝数据", OleDbType.VarChar,255)};
            parameters[0].Value = model.测试时间;
            parameters[1].Value = model.二维码;
            parameters[2].Value = model.正螺丝数据;
            parameters[3].Value = model.反螺丝数据;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MTDBAccess.Model.dbModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update db set ");
            strSql.Append("二维码=@二维码,");
            strSql.Append("正螺丝数据=@正螺丝数据,");
            strSql.Append("反螺丝数据=@反螺丝数据");
            strSql.Append(" where 测试时间=@测试时间 and 二维码=@二维码 and 正螺丝数据=@正螺丝数据 and 反螺丝数据=@反螺丝数据 ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@二维码", OleDbType.VarChar,255),
					new OleDbParameter("@正螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@反螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@测试时间", OleDbType.VarChar,255)};
            parameters[0].Value = model.二维码;
            parameters[1].Value = model.正螺丝数据;
            parameters[2].Value = model.反螺丝数据;
            parameters[3].Value = model.测试时间;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string 测试时间, string 二维码, string 正螺丝数据, string 反螺丝数据)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from db ");
            strSql.Append(" where 测试时间=@测试时间 and 二维码=@二维码 and 正螺丝数据=@正螺丝数据 and 反螺丝数据=@反螺丝数据 ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@测试时间", OleDbType.VarChar,255),
					new OleDbParameter("@二维码", OleDbType.VarChar,255),
					new OleDbParameter("@正螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@反螺丝数据", OleDbType.VarChar,255)			};
            parameters[0].Value = 测试时间;
            parameters[1].Value = 二维码;
            parameters[2].Value = 正螺丝数据;
            parameters[3].Value = 反螺丝数据;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MTDBAccess.Model.dbModel GetModel(string 测试时间, string 二维码, string 正螺丝数据, string 反螺丝数据)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 测试时间,二维码,正螺丝数据,反螺丝数据 from db ");
            strSql.Append(" where 测试时间=@测试时间 and 二维码=@二维码 and 正螺丝数据=@正螺丝数据 and 反螺丝数据=@反螺丝数据 ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@测试时间", OleDbType.VarChar,255),
					new OleDbParameter("@二维码", OleDbType.VarChar,255),
					new OleDbParameter("@正螺丝数据", OleDbType.VarChar,255),
					new OleDbParameter("@反螺丝数据", OleDbType.VarChar,255)			};
            parameters[0].Value = 测试时间;
            parameters[1].Value = 二维码;
            parameters[2].Value = 正螺丝数据;
            parameters[3].Value = 反螺丝数据;

            MTDBAccess.Model.dbModel model = new MTDBAccess.Model.dbModel();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MTDBAccess.Model.dbModel DataRowToModel(DataRow row)
        {
            MTDBAccess.Model.dbModel model = new MTDBAccess.Model.dbModel();
            if (row != null)
            {
                if (row["测试时间"] != null)
                {
                    model.测试时间 = row["测试时间"].ToString();
                }
                if (row["二维码"] != null)
                {
                    model.二维码 = row["二维码"].ToString();
                }
                if (row["正螺丝数据"] != null)
                {
                    model.正螺丝数据 = row["正螺丝数据"].ToString();
                }
                if (row["反螺丝数据"] != null)
                {
                    model.反螺丝数据 = row["反螺丝数据"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 测试时间,二维码,正螺丝数据,反螺丝数据 ");
            strSql.Append(" FROM db ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM db ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.反螺丝数据 desc");
            }
            strSql.Append(")AS Row, T.*  from db T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "db";
            parameters[1].Value = "反螺丝数据";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetOneData(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 测试时间,二维码,正螺丝数据,反螺丝数据 ");
            strSql.Append(" FROM db ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}



