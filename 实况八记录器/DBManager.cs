using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace 实况八记录器
{
    public class DBManager
    {
        private SqlConnection conn;
        public DataSet dsPL = new DataSet();
        public DataSet dsSD = new DataSet();
        public DataSet dsLC = new DataSet();
        public DataSet dsCL = new DataSet();
        public DataSet dsRecords = new DataSet();
        public SqlDataAdapter sdaPL = new SqlDataAdapter();
        public SqlDataAdapter sdaSD = new SqlDataAdapter();
        public SqlDataAdapter sdaLC = new SqlDataAdapter();
        public SqlDataAdapter sdaCL = new SqlDataAdapter();
        public SqlDataAdapter sdaRecords = new SqlDataAdapter();
        public DBManager() {
            conn = ConnectionControl.getConnection();
            SqlCommandBuilder scbPL = new SqlCommandBuilder(sdaPL);
            SqlCommandBuilder scbSD = new SqlCommandBuilder(sdaSD);
            SqlCommandBuilder scbLC = new SqlCommandBuilder(sdaLC);
            SqlCommandBuilder scbCL = new SqlCommandBuilder(sdaCL);
            SqlCommandBuilder scbRecords = new SqlCommandBuilder(sdaRecords);
            conn.Open();
        }
        //static SqlDataAdapter sda = new SqlDataAdapter();
        //static DataSet ds = new DataSet();
        
        //static SqlCommandBuilder scb = new SqlCommandBuilder(sda);
        //修改甲级联赛信息
        public DataTable getAllPLSeason() {
            
            string sql = "select * from PremierLeague";
            SqlCommand cmd = ConnectionControl.getSqlCommand(sql);
            sdaPL.SelectCommand = cmd;
            dsPL.Clear();
            sdaPL.Fill(dsPL, "PremierLeague");
            return dsPL.Tables["PremierLeague"];
        }
        public void UpdataPremierLeague(DataTable modifiedTable)
        {
            sdaPL.Update(modifiedTable);
        }
        public void DeletePremierLeague(string[] key) {
            string SqlStr;
            SqlCommand deletePL = new SqlCommand();
            SqlStr = "delete from PremierLeague where 赛季=@Season";//查询字符串 
            deletePL.Connection = conn;//设置连接 
            deletePL.CommandType = CommandType.Text;//设置命令类型 
            deletePL.CommandText = SqlStr;//设置命令文本 
            foreach (string id in key)
            {
                deletePL.Parameters.Clear();
                deletePL.Parameters.AddWithValue("@Season", id);
                sdaPL.SelectCommand = deletePL;//执行SQL语句 
                sdaPL.Fill(dsPL, "PremierLeague");//刷新记录集
                
            }
        }
        //修改乙级联赛信息
        public DataTable getAllSDSeason()
        {
            string sql = "select * from SecondDivision";
            SqlCommand cmd = ConnectionControl.getSqlCommand(sql);
            sdaSD.SelectCommand = cmd;
            dsSD.Clear();
            sdaSD.Fill(dsSD, "SecondDivision");
            return dsSD.Tables["SecondDivision"];
        }
        public void UpdataSecondDivision(DataTable modifiedTable)
        {
            sdaSD.Update(modifiedTable);
        }
        public void DeleteSecondDivision(string[] key)
        {
            string SqlStr;
            SqlCommand deleteSD = new SqlCommand();
            SqlStr = "delete from SecondDivision where 赛季=@Season";//查询字符串 
            deleteSD.Connection = conn;//设置连接 
            deleteSD.CommandType = CommandType.Text;//设置命令类型 
            deleteSD.CommandText = SqlStr;//设置命令文本 
            foreach (string id in key)
            {
                deleteSD.Parameters.Clear();
                deleteSD.Parameters.AddWithValue("@Season", id);
                sdaSD.SelectCommand = deleteSD;//执行SQL语句 
                sdaSD.Fill(dsSD, "SecondDivision");//刷新记录集
            }
        }
        //修改甲级联赛杯信息
        public DataTable getAllLCSeason()
        {
            string sql = "select * from LeagueCup";
            SqlCommand cmd = ConnectionControl.getSqlCommand(sql);
            sdaLC.SelectCommand = cmd;
            dsLC.Clear();
            sdaLC.Fill(dsLC, "LeagueCup");
            return dsLC.Tables["LeagueCup"];
        }
        public void UpdataLeagueCup(DataTable modifiedTable)
        {
            sdaLC.Update(modifiedTable);
        }
        public void DeleteLeagueCup(string[] key)
        {
            string SqlStr;
            SqlCommand deleteLC = new SqlCommand();
            SqlStr = "delete from LeagueCup where 赛季=@Season";//查询字符串 
            deleteLC.Connection = conn;//设置连接 
            deleteLC.CommandType = CommandType.Text;//设置命令类型 
            deleteLC.CommandText = SqlStr;//设置命令文本 
            foreach (string id in key)
            {
                deleteLC.Parameters.Clear();
                deleteLC.Parameters.AddWithValue("@Season", id);
                sdaLC.SelectCommand = deleteLC;//执行SQL语句 
                sdaLC.Fill(dsLC, "LeagueCup");//刷新记录集
            }
        }
        //修改欧冠信息
        public DataTable getAllCLSeason()
        {
            string sql = "select * from ChampionsLeague";
            SqlCommand cmd = ConnectionControl.getSqlCommand(sql);
            sdaCL.SelectCommand = cmd;
            dsCL.Clear();
            sdaCL.Fill(dsCL, "ChampionsLeague");
            return dsCL.Tables["ChampionsLeague"];
        }
        public void UpdataChampionsLeague(DataTable modifiedTable)
        {
            sdaCL.Update(modifiedTable);
        }
        public void DeleteChampionsLeague(string[] key)
        {
            string SqlStr;
            SqlCommand deleteCL = new SqlCommand();
            SqlStr = "delete from ChampionsLeague where 赛季=@Season";//查询字符串 
            deleteCL.Connection = conn;//设置连接 
            deleteCL.CommandType = CommandType.Text;//设置命令类型 
            deleteCL.CommandText = SqlStr;//设置命令文本 
            foreach (string id in key)
            {
                deleteCL.Parameters.Clear();
                deleteCL.Parameters.AddWithValue("@Season", id);
                sdaCL.SelectCommand = deleteCL;//执行SQL语句 
                sdaCL.Fill(dsCL, "ChampionsLeague");//刷新记录集
            }
        }
        //修改名人堂信息
        public DataTable getAllRecords()
        {
            string sql = "select * from Records";
            SqlCommand cmd = ConnectionControl.getSqlCommand(sql);
            sdaRecords.SelectCommand = cmd;
            dsRecords.Clear();
            sdaRecords.Fill(dsRecords, "Records");
            return dsRecords.Tables["Records"];
        }
        public void UpdataRecords(DataTable modifiedTable)
        {
            sdaRecords.Update(modifiedTable);
        }
        public void DeleteRecords(string[] key)
        {
            string SqlStr;
            SqlCommand deleteRecords = new SqlCommand();
            SqlStr = "delete from Records where 序号=@Season";//查询字符串 
            deleteRecords.Connection = conn;//设置连接 
            deleteRecords.CommandType = CommandType.Text;//设置命令类型 
            deleteRecords.CommandText = SqlStr;//设置命令文本 
            foreach (string id in key)
            {
                deleteRecords.Parameters.Clear();
                deleteRecords.Parameters.AddWithValue("@Season", id);
                sdaRecords.SelectCommand = deleteRecords;//执行SQL语句 
                sdaRecords.Fill(dsRecords, "Records");//刷新记录集
            }
        }
    }
}
