using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testt
{
    public partial class added : Form
    {

        public string SavedProjectName { get; private set; }

        private List<(string category, string name, double amount)> CollectAllData()
        {
            var list = new List<(string, string, double)>();

            void ReadGrid(DataGridView dgv, string category)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                        continue;

                    if (double.TryParse(row.Cells[1].Value.ToString(), out double amount))
                    {
                        list.Add((
                            category,
                            row.Cells[0].Value.ToString(),
                            amount
                        ));
                    }
                }
            }

            ReadGrid(IncomeData, "Income");
            ReadGrid(ExpensesData, "Expenses");
            ReadGrid(BillsData, "Bills");
            ReadGrid(SavingsData, "Savings");
            ReadGrid(DebtData, "Debt");

            return list;
        }
        public added()
        {
            InitializeComponent();
            SetRoundedButton(btnAdd, 20);
            SetRoundedButton(btnRemove, 20);
            SetRoundedButton(btnAdd1, 20);
            SetRoundedButton(btnRemove1, 20);
            SetRoundedButton(btnAdd2, 20);
            SetRoundedButton(btnRemove2, 20);
            SetRoundedButton(btnAdd3, 20);
            SetRoundedButton(btnRemove3, 20);
            SetRoundedButton(btnAdd4, 20);
            SetRoundedButton(btnRemove4, 20);

            SetTopRounded(lblIncome, 10);
            SetTopRounded(lblExpenses, 10);
            SetTopRounded(lblBills, 10);
            SetTopRounded(lblSavings, 10);
            SetTopRounded(lblDebt, 10);
            SetTopRounded(lblSummary, 10);
        }
        private void SetRoundedButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.BackColor = Color.LightSalmon;
            btnAdd.ForeColor = Color.White;

            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.BackColor = Color.LightSalmon;
            btnRemove.ForeColor = Color.White;

            btnAdd1.FlatStyle = FlatStyle.Flat;
            btnAdd1.FlatAppearance.BorderSize = 0;
            btnAdd1.BackColor = Color.LightSalmon;
            btnAdd1.ForeColor = Color.White;

            btnRemove1.FlatStyle = FlatStyle.Flat;
            btnRemove1.FlatAppearance.BorderSize = 0;
            btnRemove1.BackColor = Color.LightSalmon;
            btnRemove1.ForeColor = Color.White;

            btnAdd2.FlatStyle = FlatStyle.Flat;
            btnAdd2.FlatAppearance.BorderSize = 0;
            btnAdd2.BackColor = Color.LightSalmon;
            btnAdd2.ForeColor = Color.White;

            btnRemove2.FlatStyle = FlatStyle.Flat;
            btnRemove2.FlatAppearance.BorderSize = 0;
            btnRemove2.BackColor = Color.LightSalmon;
            btnRemove2.ForeColor = Color.White;

            btnAdd3.FlatStyle = FlatStyle.Flat;
            btnAdd3.FlatAppearance.BorderSize = 0;
            btnAdd3.BackColor = Color.LightSalmon;
            btnAdd3.ForeColor = Color.White;

            btnRemove3.FlatStyle = FlatStyle.Flat;
            btnRemove3.FlatAppearance.BorderSize = 0;
            btnRemove3.BackColor = Color.LightSalmon;
            btnRemove3.ForeColor = Color.White;

            btnAdd4.FlatStyle = FlatStyle.Flat;
            btnAdd4.FlatAppearance.BorderSize = 0;
            btnAdd4.BackColor = Color.LightSalmon;
            btnAdd4.ForeColor = Color.White;

            btnRemove4.FlatStyle = FlatStyle.Flat;
            btnRemove4.FlatAppearance.BorderSize = 0;
            btnRemove4.BackColor = Color.LightSalmon;
            btnRemove4.ForeColor = Color.White;
        }
        private void SetTopRounded(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(ctrl.Width, ctrl.Height, 0, ctrl.Height);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }

        private void TitleCenter_Click(object sender, EventArgs e)
        {

        }
        private float gradientShift = 0;
        private void TitleCenter_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                TitleCenter.ClientRectangle,
                Color.White,
                Color.Black,
                LinearGradientMode.Horizontal))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[]
                {
                  Color.LightBlue,
                  Color.SeaShell,
                  Color.Pink
                };

                blend.Positions = new float[]
                {
                 0f,
                 gradientShift,
                 1f
                };

                brush.InterpolationColors = blend;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                e.Graphics.DrawString(
                    TitleCenter.Text,
                    TitleCenter.Font,
                    brush,
                    new PointF(0, 0));
            }
        }
        private void TitleCenter_MouseMove(object sender, MouseEventArgs e)
        {
            gradientShift = (float)e.X / this.Width;
            TitleCenter.Invalidate();
        }

        private void HelpBox_Click(object sender, EventArgs e)
        {
            Help form3 = new Help();
            form3.Show();
        }

        private void BackArrowBox_Click(object sender, EventArgs e)
        {
            BBForm form1 = new BBForm();
            form1.Show();
            this.Close();
        }

        private void ProjectName_DoubleClick(object sender, EventArgs e)
        {
            TextBox txtEdit = new TextBox();

            txtEdit.Text = ProjectName.Text;
            txtEdit.Font = ProjectName.Font;
            txtEdit.Bounds = ProjectName.Bounds;

            txtEdit.BorderStyle = BorderStyle.None;
            txtEdit.BackColor = PanelTitle.BackColor;
            txtEdit.ForeColor = ProjectName.ForeColor;
            txtEdit.TextAlign = HorizontalAlignment.Center;

            PanelTitle.Controls.Add(txtEdit);
            txtEdit.BringToFront();
            txtEdit.Focus();

            PanelTitle.Controls.Add(txtEdit);
            txtEdit.BringToFront();
            txtEdit.Focus();

            txtEdit.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    ProjectName.Text = txtEdit.Text;
                    PanelTitle.Controls.Remove(txtEdit);
                    ProjectName.Text = string.IsNullOrWhiteSpace(txtEdit.Text) ? "Title" : txtEdit.Text;
                    PanelTitle.Controls.Remove(txtEdit);
                }
            };
            txtEdit.Leave += (s, ev) =>
            {
                ProjectName.Text = txtEdit.Text;
                PanelTitle.Controls.Remove(txtEdit);
                ProjectName.Text = string.IsNullOrWhiteSpace(txtEdit.Text) ? "Title" : txtEdit.Text;
                PanelTitle.Controls.Remove(txtEdit);
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IncomeData.Rows.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            {
                if (IncomeData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in IncomeData.SelectedRows)
                    {
                        IncomeData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            ExpensesData.Rows.Add();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            {
                if (ExpensesData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in ExpensesData.SelectedRows)
                    {
                        ExpensesData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            BillsData.Rows.Add();
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            {
                if (BillsData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in BillsData.SelectedRows)
                    {
                        BillsData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            SavingsData.Rows.Add();
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {
            {
                if (SavingsData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in SavingsData.SelectedRows)
                    {
                        SavingsData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            DebtData.Rows.Add();
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            {
                if (DebtData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in DebtData.SelectedRows)
                    {
                        DebtData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }
        private double GetTotal(DataGridView dgv)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    double val;
                    if (double.TryParse(row.Cells[1].Value.ToString(), out val))
                    {
                        total += val;
                    }
                }
            }

            return total;
        }

        private void IncomeData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            IncomeTotal.Text = "Total: " + GetTotal(IncomeData).ToString("N2");

            if (e.ColumnIndex == 1)
            {
                var cell = IncomeData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    double value;

                    if (double.TryParse(cell.Value.ToString(), out value))
                    {
                        cell.Value = value.ToString("N0");
                    }
                    else
                    {

                        cell.Value = "";
                    }
                }
            }
            UpdateSummary();
        }
        private void ExpensesData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ExpensesTotal.Text = "Total: " + GetTotal(ExpensesData).ToString("N2");

            if (e.ColumnIndex == 1)
            {
                var cell = ExpensesData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    double value;

                    if (double.TryParse(cell.Value.ToString(), out value))
                    {
                        cell.Value = value.ToString("N0");
                    }
                    else
                    {

                        cell.Value = "";
                    }
                }
            }
            UpdateSummary();
        }
        private void BillsData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BillsTotal.Text = "Total: " + GetTotal(BillsData).ToString("N2");

            if (e.ColumnIndex == 1)
            {
                var cell = BillsData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    double value;

                    if (double.TryParse(cell.Value.ToString(), out value))
                    {
                        cell.Value = value.ToString("N0");
                    }
                    else
                    {

                        cell.Value = "";
                    }
                }
            }
            UpdateSummary();
        }
        private void SavingsData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SavingsTotal.Text = "Total: " + GetTotal(SavingsData).ToString("N2");
            if (e.ColumnIndex == 1)
            {
                var cell = SavingsData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    double value;

                    if (double.TryParse(cell.Value.ToString(), out value))
                    {
                        cell.Value = value.ToString("N0");
                    }
                    else
                    {

                        cell.Value = "";
                    }
                }
            }
            UpdateSummary();
        }
        private void DebtData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DebtTotal.Text = "Total: " + GetTotal(DebtData).ToString("N2");

            if (e.ColumnIndex == 1)
            {
                var cell = DebtData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    double value;

                    if (double.TryParse(cell.Value.ToString(), out value))
                    {
                        cell.Value = value.ToString("N0");
                    }
                    else
                    {

                        cell.Value = "";
                    }
                }
            }
            UpdateSummary();
        }

        private void IncomeData_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int col = dgv.CurrentCell.ColumnIndex;
                int row = dgv.CurrentCell.RowIndex;

                if (col < dgv.ColumnCount - 1)
                    dgv.CurrentCell = dgv.Rows[row].Cells[col + 1];
                else
                {
                    if (row == dgv.RowCount - 1)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[0];
                }
            }
        }
        private void ExpensesData_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int col = dgv.CurrentCell.ColumnIndex;
                int row = dgv.CurrentCell.RowIndex;

                if (col < dgv.ColumnCount - 1)
                    dgv.CurrentCell = dgv.Rows[row].Cells[col + 1];
                else
                {
                    if (row == dgv.RowCount - 1)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[0];
                }
            }
        }
        private void BillsData_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int col = dgv.CurrentCell.ColumnIndex;
                int row = dgv.CurrentCell.RowIndex;

                if (col < dgv.ColumnCount - 1)
                    dgv.CurrentCell = dgv.Rows[row].Cells[col + 1];
                else
                {
                    if (row == dgv.RowCount - 1)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[0];
                }
            }
        }
        private void SavingsData_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int col = dgv.CurrentCell.ColumnIndex;
                int row = dgv.CurrentCell.RowIndex;

                if (col < dgv.ColumnCount - 1)
                    dgv.CurrentCell = dgv.Rows[row].Cells[col + 1];
                else
                {
                    if (row == dgv.RowCount - 1)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[0];
                }
            }
        }
        private void DebtData_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int col = dgv.CurrentCell.ColumnIndex;
                int row = dgv.CurrentCell.RowIndex;

                if (col < dgv.ColumnCount - 1)
                    dgv.CurrentCell = dgv.Rows[row].Cells[col + 1];
                else
                {
                    if (row == dgv.RowCount - 1)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[0];
                }
            }
        }
        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void IncomeData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;

            if (tb != null)
            {
                tb.KeyPress -= Amount_KeyPress;

                if (IncomeData.CurrentCell.ColumnIndex == 1)
                {
                    tb.KeyPress += Amount_KeyPress;
                }
            }

        }
        private void ExpensesData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;

            if (tb != null)
            {
                tb.KeyPress -= Amount_KeyPress;

                if (ExpensesData.CurrentCell.ColumnIndex == 1)
                {
                    tb.KeyPress += Amount_KeyPress;
                }
            }
        }
        private void BillsData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;

            if (tb != null)
            {
                tb.KeyPress -= Amount_KeyPress;

                if (BillsData.CurrentCell.ColumnIndex == 1)
                {
                    tb.KeyPress += Amount_KeyPress;
                }
            }
        }
        private void SavingsData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;

            if (tb != null)
            {
                tb.KeyPress -= Amount_KeyPress;

                if (SavingsData.CurrentCell.ColumnIndex == 1)
                {
                    tb.KeyPress += Amount_KeyPress;
                }
            }
        }
        private void DebtData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;

            if (tb != null)
            {
                tb.KeyPress -= Amount_KeyPress;

                if (DebtData.CurrentCell.ColumnIndex == 1)
                {
                    tb.KeyPress += Amount_KeyPress;
                }
            }
        }
        private void UpdateSummary()
        {
            SummaryData.Rows.Clear();

            double income = GetTotal(IncomeData);
            double expenses = GetTotal(ExpensesData);
            double bills = GetTotal(BillsData);
            double savings = GetTotal(SavingsData);
            double debt = GetTotal(DebtData);

            double balance = income - expenses - bills - savings - debt;

            SummaryData.Rows.Add("Income", income.ToString("N0"));
            SummaryData.Rows.Add("Expenses", expenses.ToString("N0"));
            SummaryData.Rows.Add("Bills", bills.ToString("N0"));
            SummaryData.Rows.Add("Savings", savings.ToString("N0"));
            SummaryData.Rows.Add("Debt", debt.ToString("N0"));
            SummaryData.Rows.Add("Balance", balance.ToString("N0"));

            int lastRow = SummaryData.Rows.Count - 1;

            if (balance >= 0)
                SummaryData.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Green;
            else
                SummaryData.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Red;
        }

        private async void SaveBox_Click(object sender, EventArgs e)
        {
            var items = CollectAllData();

            if (string.IsNullOrEmpty(ProjectName.Text))
            {
                MessageBox.Show("Project name is required");
                return;
            }

            await InsertProject(ProjectName.Text, items);

            SavedProjectName = ProjectName.Text;

            MessageBox.Show("Saved successfully");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async Task InsertProject(string ProjectName, List<(string category, string name, double amount)> items)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("apikey", deytabeys.Apikey);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + deytabeys.Apikey);

                var projectData = new
                {
                    project_name = ProjectName
                };

                string projectJson = JsonConvert.SerializeObject(projectData);

                var projectContent = new StringContent(projectJson, Encoding.UTF8, "application/json");

                var responce = await client.PostAsync($"{deytabeys.Url}/rest/v1/budget_projects", projectContent);

                if (!responce.IsSuccessStatusCode)
                {
                    MessageBox.Show(await responce.Content.ReadAsStringAsync());
                    return;
                }

                int projectid = 1;

                foreach (var item in items)
                {
                    var data = new
                    {
                        project_id = projectid,
                        category = item.category,
                        item_name = item.name,
                        amount = item.amount
                    };

                    string json = JsonConvert.SerializeObject(data);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    await client.PostAsync(
                        $"{deytabeys.Url}/rest/v1/budget_items", content);

                }
            }
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {

        }

        private void lblIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            IncomeData.Rows.Add();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            {
                if (IncomeData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in IncomeData.SelectedRows)
                    {
                        IncomeData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }

        private void btnAdd2_Click_1(object sender, EventArgs e)
        {
            BillsData.Rows.Add();
        }

        private void btnAdd4_Click_1(object sender, EventArgs e)
        {
            DebtData.Rows.Add();
        }

        private void btnRemove2_Click_1(object sender, EventArgs e)
        {
            {
                if (BillsData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in BillsData.SelectedRows)
                    {
                        BillsData.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }
        }
    }
}
