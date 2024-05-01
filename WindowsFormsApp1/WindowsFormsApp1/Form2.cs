﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;
        private const string conn_str =
            @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";

        public Form2()
        {
            InitializeComponent();
            InitializeDBConn();
        }

        private void InitializeDBConn()
        {
            try
            {
                conn = new MySqlConnection(conn_str);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Sikertelen csatlakozás az adatbázishoz: {e}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectList pl = new ProjectList();
            pl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectCompList pcl = new ProjectCompList();
            pcl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Optimizer opt = new Optimizer();
            opt.InitAdjMat();

            Optimizer.Cell start = new Optimizer.Cell(0, 0, 0),
                end = new Optimizer.Cell(9, 3, 5);

            List<Optimizer.Cell> sPath = opt.FindShortestPath(start, end);

            foreach(var cell in sPath)
            {
                InsertIntoDB(cell.Row, cell.Column, cell.Level);
            }
        }

        private void InsertIntoDB(int r, int c, int l)
        {
            try
            {
                string query = "INSERT INTO Raktar(Sor, Oszlop, Polc) VALUES (@r, @c, @l)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@r", r);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@l", l);
                cmd.ExecuteNonQuery();
            } catch(Exception e)
            {
                MessageBox.Show($"Hiba a táblába való beszúrás során: {e}");
            }
        }

        
    }

    public class Optimizer
    {
        public class Cell
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public int Level { get; set; }

            public Cell(int row, int column, int level)
            {
                Row = row;
                Column = column;
                Level = level;
            }
        }

        private const int Rows = 10;
        private const int Columns = 4;
        private const int Levels = 6;

        private int[,,] adjMat = new int[Rows, Columns, Levels];

        public void InitAdjMat()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    for (int k = 0; k < Levels; k++)
                    {
                        adjMat[i, j, k] = 1;
                    }
                }
            }
        }

        public List<Cell> FindShortestPath(Cell start, Cell end)
        {
            int[,,] d = new int[Rows, Columns, Levels];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    for (int k = 0; k < Levels; k++)
                    {
                        d[i, j, k] = int.MaxValue;
                    }
                }
            }

            d[start.Row, start.Column, start.Level] = 0;

            bool[,,] visited = new bool[Rows, Columns, Levels];

            while (true)
            {
                int minD = int.MaxValue;
                Cell closest = null;
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        for (int k = 0; k < Levels; k++)
                        {
                            if (!visited[i, j, k] && d[i, j, k] < minD)
                            {
                                minD = d[i, j, k];
                                closest = new Cell(i, j, k);
                            }
                        }
                    }
                }

                if (closest == null) break;

                visited[closest.Row, closest.Column, closest.Level] = true;

                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            int newRow = closest.Row + i;
                            int newColumn = closest.Column + j;
                            int newLevel = closest.Level + k;

                            if (newRow >= 0 && newRow < Rows &&
                                newColumn >= 0 && newColumn < Columns &&
                                newLevel >= 0 && newLevel < Levels)
                            {
                                int newD = d[closest.Row, closest.Column, closest.Level] +
                                    adjMat[newRow, newColumn, newLevel];
                                if (newD < d[newRow, newColumn, newLevel])
                                {
                                    d[newRow, newColumn, newLevel] = newD;
                                }
                            }
                        }
                    }
                }
            }

            List<Cell> sPath = new List<Cell>();
            Cell curr = end;
            while (curr != null)
            {
                sPath.Add(curr);
                int minD = int.MaxValue;
                Cell next = null;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            int newRow = curr.Row + i;
                            int newColumn = curr.Column + j;
                            int newLevel = curr.Level + k;

                            if (newRow >= 0 && newRow < Rows &&
                                newColumn >= 0 && newColumn < Columns &&
                                newLevel >= 0 && newLevel < Levels &&
                                d[newRow, newColumn, newLevel] < minD)
                            {
                                minD = d[newRow, newColumn, newLevel];
                                next = new Cell(newRow, newColumn, newLevel);
                            }
                        }
                    }
                }
                curr = next;
            }

            sPath.Reverse();
            return sPath;
        }
    }
}
