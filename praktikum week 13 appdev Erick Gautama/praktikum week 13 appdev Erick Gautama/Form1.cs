using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum_week_13_appdev_Erick_Gautama
{
    public partial class Formhome : Form
    {
        public Formhome()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("host=localhost;uid=root;pwd=;database=Premier_League;");
        string queryfull = "select m.match_date as `date`, t.team_name as `team`, p.player_name as `player`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from `match` m, team t, player p, dmatch d where d.match_id = m.match_id and p.team_id = t.team_id and d.team_id = t.team_id and d.player_id = p.player_id  group by player_name having sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) != 0 order by  team_name, `gol`;";
        string querytanggal = "select match_date as `date`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol`from `match` m, dmatch d where d.match_id = m.match_id group by match_date having `gol` != 0 order by match_date;";
        string queryteam = "select t.team_name as `team` , sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from team t, dmatch d where d.team_id = t.team_id group by team_name having `gol` != 0 order by team_name;";
        string querynama = "select player_name as `player`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from player p, dmatch d where p.player_id = d.player_id group by player_name having `gol` != 0 order by player_name;";
        string querytangtim = "select m.match_date as `date`, t.team_name as `team`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from `match` m, team t, dmatch d where d.match_id = m.match_id and d.team_id = t.team_id group by match_date having `gol` != 0 order by match_date;";
        string querytangnam = "select m.match_date as `date`, p.player_name as `player`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from `match` m, player p, dmatch d where d.match_id = m.match_id and d.player_id = p.player_id group by match_date having `gol` != 0 order by match_date;";
        string queryteamnam = "select t.team_name as `team`, p.player_name as `player`, sum(if(d.`type` = 'GO' OR d.`type` = 'GP',1,0)) as `gol` from team t, player p, dmatch d where d.team_id = t.team_id and d.player_id = p.player_id group by player_name having `gol` != 0 order by team_name,`gol`;";
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable tabel = new DataTable();
        private void Formhome_Load(object sender, EventArgs e)
        {

            try
            {
                command = new MySqlCommand(queryfull, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(tabel);
                dataGridtabel.DataSource = tabel;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            checkBoxtanggal.Checked = true;
            checkBoxteam.Checked = true;
            checkBoxnama.Checked = true;

        }

        private void checkBoxtanggal_CheckedChanged(object sender, EventArgs e)
        {
           
            tabel.Columns.Clear();
            tabel.Clear();
            if (checkBoxtanggal.Checked == true)
            {
                if (checkBoxnama.Checked == true && checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryfull, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxnama.Checked == true)
                {
                    command = new MySqlCommand(querytangnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(querytangtim, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    command = new MySqlCommand(querytanggal, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
            }
            else if (checkBoxtanggal.Checked == false)
            {
                if (checkBoxnama.Checked == true && checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryteamnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxnama.Checked == true)
                {
                    command = new MySqlCommand(querynama, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryteam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    MessageBox.Show("Error! please choose at least 1");
                    //checkBoxtanggal.Checked = true;
                }
            }
        }

        private void checkBoxteam_CheckedChanged(object sender, EventArgs e)
        {
            
            tabel.Columns.Clear();
            tabel.Clear();
            if (checkBoxteam.Checked == true)
            {
                if (checkBoxnama.Checked == true && checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(queryfull, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxnama.Checked == true)
                {
                    command = new MySqlCommand(queryteamnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(querytangtim, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    command = new MySqlCommand(queryteam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
            }
            else if (checkBoxteam.Checked == false)
            {
                if (checkBoxnama.Checked == true && checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(querytangnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxnama.Checked == true)
                {
                    command = new MySqlCommand(querynama, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(querytanggal, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    MessageBox.Show("Error! please choose at least 1");
                    //checkBoxteam.Checked = true;
                }
            }
        }

        private void checkBoxnama_CheckedChanged(object sender, EventArgs e)
        {
           
            tabel.Columns.Clear();
            tabel.Clear();
            if (checkBoxnama.Checked == true)
            {
                if (checkBoxtanggal.Checked == true && checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryfull, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(querytangnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryteamnam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    command = new MySqlCommand(querynama, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
            }
            else if (checkBoxnama.Checked == false)
            {
                if (checkBoxtanggal.Checked == true && checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(querytangtim, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxtanggal.Checked == true)
                {
                    command = new MySqlCommand(querytanggal, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else if (checkBoxteam.Checked == true)
                {
                    command = new MySqlCommand(queryteam, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabel);
                    dataGridtabel.DataSource = tabel;
                }
                else
                {
                    MessageBox.Show("Error! please choose at least 1");
                    //checkBoxnama.Checked = true;
                }
            }
        }
    }
}