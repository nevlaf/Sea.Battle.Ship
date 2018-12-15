using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sea.Battle.Ship.Controllers;
using Sea.Battle.Ship.Model;
using Sea.Battle.Ship.Views;



namespace Sea.Battle.Ship.Views
{
    public partial class FormMain : Form
    {
        #region Variables
        /// <summary>
        /// Размер ячейки моря
        /// </summary>
        private int size = 20;



        #endregion

        #region Constructors;

        public FormMain()
        {
            InitializeComponent();
            CreateSea(seaOwnPanel);
            CreateSea(seaEnemyPanel);
            Game.Init();
        }

        #endregion

        #region Event

        private void Cell_Click(object sender, EventArgs e)
        {
           // string massege = string.Format("i:{0}, i:{1}, i:({2})",
           //     (sender as Cell).i,
           //     (sender as Cell).j,
           //     (sender as Cell).Parent.Name);
           // MessageBox.Show(massege);
           if((sender as Cell).Parent.Name == "seaOwnPanel")
            {
                if( Game.seaOwn[(sender as Cell).i, (sender as Cell).j]  == CellState.Empty)
                {
                    Game.seaOwn[(sender as Cell).i, (sender as Cell).j] = CellState.Miss;
                    UpdateSea((sender as Cell).Parent as Panel);
                }
            }
        }

        private void UpdateSea(Panel panel)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(panel.Name == "seaOwnPanel")
                    {
                        switch (Game.seaOwn[i,j])
                        {
                            case CellState.Empty:
                                break;
                            case CellState.Ship:
                                break;
                            case CellState.Miss:
                                panel.Controls.Find(String.Format("{0}_{1}", i, j), false)[0].Text = "0";
                                (panel.Controls.Find(String.Format("{0}_{1}", i, j), false)[0] as Cell).TextAlign = ContentAlignment.MiddleCenter;
                                ((panel.Controls.Find(String.Format("{0}_{1}", i, j), false)[0] as Cell).Parent as Panel).Select();
                                break;
                            case CellState.Hit:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }




        #endregion


        #region Methods

        /// <summary>
        /// Методсоздает массив ячеек игрового моря
        /// </summary>
        /// <param name="panel"></param>

        private void CreateSea(Panel panel)
        {
            char[] gorizontal = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            char[] vertical = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Cell cell = new Cell(i, j)
                    {
                        Name = string.Format("{0}_{1}", i, j),
                        Left = size + i * size,
                        Top = size + j * size,
                        Width = size,
                        Height = size,
                    };
                    cell.Click += Cell_Click;
                    panel.Controls.Add(cell);
                }

                panel.Controls.Add(new Label()
                {
                    Left = 0,
                    Top = size + j * size,
                    Width = size,
                    Height = size,
                    Text = vertical[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                });

                panel.Controls.Add(new Label()
                {
                    Left = size + j * size,
                    Top = 0,
                    Width = size,
                    Height = size,
                    Text = gorizontal[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                });


            }
            #endregion
        }





    }
}