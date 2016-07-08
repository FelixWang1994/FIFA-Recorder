using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace 实况八记录器
{
    public partial class Main : Form
    {
        private DBManager dbm;
        public static bool flag = true;
        public Main()
        {
            InitializeComponent();
        }
        public void fillPremierLeagueDatagridview() {
            PremierLeagueDatagridview.DataSource = dbm.getAllPLSeason();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.dbm = new DBManager();
            this.fillPremierLeagueDatagridview();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出程序", "退出程序", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                System.Environment.Exit(System.Environment.ExitCode); 
            else
            {
                e.Cancel = true;
                return;
            }
        }
        //修改甲级联赛
        private void btAddToPL_Click(object sender, EventArgs e)
        {
            DataTable changedDT = (DataTable)PremierLeagueDatagridview.DataSource;
            try
            {
                dbm.UpdataPremierLeague(changedDT);
                PremierLeagueDatagridview.DataSource = dbm.getAllPLSeason();
                MessageBox.Show("保存成功！");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefreshPL_Click(object sender, EventArgs e)
        {
            PremierLeagueDatagridview.DataSource = dbm.getAllPLSeason();
        }

        private void btDeletePL_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in PremierLeagueDatagridview.SelectedRows)
            {
                i++;
            }
            string[] s = new String[i];
            foreach (DataGridViewRow row in PremierLeagueDatagridview.SelectedRows)
            {
                s[j] = PremierLeagueDatagridview.SelectedRows[j].Cells[0].Value.ToString();
                j++;
            }

            if (i == 0)
            {
                MessageBox.Show("未选中数据");
            }
            else
            {
                dbm.DeletePremierLeague(s);
                MessageBox.Show("删除成功！");
                PremierLeagueDatagridview.DataSource = dbm.getAllPLSeason();
            }
        }
        //修改乙级联赛
        private void btAddToSD_Click(object sender, EventArgs e)
        {
            DataTable changedDT = (DataTable)SecondDivisionDatagridview.DataSource;
            try
            {
                dbm.UpdataSecondDivision(changedDT);
                SecondDivisionDatagridview.DataSource = dbm.getAllSDSeason();
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefreshSD_Click(object sender, EventArgs e)
        {
            SecondDivisionDatagridview.DataSource = dbm.getAllSDSeason();
        }

        private void btDeleteSD_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in SecondDivisionDatagridview.SelectedRows)
            {
                i++;
            }
            string[] s = new String[i];
            foreach (DataGridViewRow row in SecondDivisionDatagridview.SelectedRows)
            {
                s[j] = SecondDivisionDatagridview.SelectedRows[j].Cells[0].Value.ToString();
                j++;
            }

            if (i == 0)
            {
                MessageBox.Show("未选中数据");
            }
            else
            {
                dbm.DeleteSecondDivision(s);
                MessageBox.Show("删除成功！");
                SecondDivisionDatagridview.DataSource = dbm.getAllSDSeason();
            }
        }
        //刷新标签页
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex) { 
                case 0:
                    PremierLeagueDatagridview.DataSource = dbm.getAllPLSeason();
                    break;
                case 1:
                    SecondDivisionDatagridview.DataSource = dbm.getAllSDSeason();
                    break;
                case 2:
                    LeagueCupDatagridview.DataSource = dbm.getAllLCSeason();
                    break;
                case 3:
                    ChampionsLeagueDatagridview.DataSource = dbm.getAllCLSeason();
                    break;
                case 4:
                    RecordsDatagridview.DataSource = dbm.getAllRecords();
                    break;
            }
        }
        //修改甲级联赛杯
        private void btAddToLC_Click(object sender, EventArgs e)
        {
            DataTable changedDT = (DataTable)LeagueCupDatagridview.DataSource;
            try
            {
                dbm.UpdataLeagueCup(changedDT);
                MessageBox.Show("保存成功！");
                LeagueCupDatagridview.DataSource = dbm.getAllLCSeason();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefreshLC_Click(object sender, EventArgs e)
        {
            LeagueCupDatagridview.DataSource = dbm.getAllLCSeason();
        }

        private void btDeleteLC_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in LeagueCupDatagridview.SelectedRows)
            {
                i++;
            }
            string[] s = new String[i];
            foreach (DataGridViewRow row in LeagueCupDatagridview.SelectedRows)
            {
                s[j] = LeagueCupDatagridview.SelectedRows[j].Cells[0].Value.ToString();
                j++;
            }

            if (i == 0)
            {
                MessageBox.Show("未选中数据");
            }
            else
            {
                dbm.DeleteLeagueCup(s);
                MessageBox.Show("删除成功！");
                LeagueCupDatagridview.DataSource = dbm.getAllLCSeason();
            }
        }
        //修改欧冠
        private void btAddToCL_Click(object sender, EventArgs e)
        {
            DataTable changedDT = (DataTable)ChampionsLeagueDatagridview.DataSource;
            try
            {
                dbm.UpdataChampionsLeague(changedDT);
                MessageBox.Show("保存成功！");
                ChampionsLeagueDatagridview.DataSource = dbm.getAllCLSeason();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefreshCL_Click(object sender, EventArgs e)
        {
            ChampionsLeagueDatagridview.DataSource = dbm.getAllCLSeason();
        }

        private void btDeleteCL_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in ChampionsLeagueDatagridview.SelectedRows)
            {
                i++;
            }
            string[] s = new String[i];
            foreach (DataGridViewRow row in ChampionsLeagueDatagridview.SelectedRows)
            {
                s[j] = ChampionsLeagueDatagridview.SelectedRows[j].Cells[0].Value.ToString();
                j++;
            }

            if (i == 0)
            {
                MessageBox.Show("未选中数据");
            }
            else
            {
                dbm.DeleteChampionsLeague(s);
                MessageBox.Show("删除成功！");
                ChampionsLeagueDatagridview.DataSource = dbm.getAllCLSeason();
            }
        }
        //修改名人堂
        private void btAddToRecords_Click(object sender, EventArgs e)
        {
            DataTable changedDT = (DataTable)RecordsDatagridview.DataSource;
            try
            {
                dbm.UpdataRecords(changedDT);
                MessageBox.Show("保存成功！");
                RecordsDatagridview.DataSource = dbm.getAllRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefreshRecords_Click(object sender, EventArgs e)
        {
            RecordsDatagridview.DataSource = dbm.getAllRecords();
        }

        private void btDeleteRecords_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in RecordsDatagridview.SelectedRows)
            {
                i++;
            }
            string[] s = new String[i];
            foreach (DataGridViewRow row in RecordsDatagridview.SelectedRows)
            {
                s[j] = RecordsDatagridview.SelectedRows[j].Cells[0].Value.ToString();
                j++;
            }

            if (i == 0)
            {
                MessageBox.Show("未选中数据");
            }
            else
            {
                dbm.DeleteRecords(s);
                MessageBox.Show("删除成功！");
                RecordsDatagridview.DataSource = dbm.getAllRecords();
            }
        }

        

        

        

        
    }
}
