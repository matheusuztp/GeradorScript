using ClosedXML.Excel;
using System.Text;

namespace GeradorScriptExcel
{

    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
            cbSeparador.SelectedIndex = 0;
        }


        private void btnAbrirExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtUrlExcel.Text = ofd.FileName;
                }
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string filePath = txtUrlExcel.Text; // Obtém o caminho do arquivo Excel do TextBox
            string sqlScope = txtEscopo.Text; // Escopo do SQL, incluindo a lista de colunas
            int startRow = (int)linhaInicial.Value;
            int endRow = (int)linhaFinal.Value;
            string separator = cbSeparador.SelectedItem.ToString();

            if (startRow > endRow)
            {
                MessageBox.Show("A linha inicial não pode ser maior que a linha final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            StringBuilder sqlBuilder = new StringBuilder();

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    for (int i = startRow; i <= endRow; i++)
                    {
                        string currentSql = sqlScope;

                        for (char columnLetter = 'A'; columnLetter <= 'Z'; columnLetter++)
                        {
                            string placeholder = $"[{columnLetter}]";

                            if (currentSql.Contains(placeholder))
                            {
                                string cellValue = worksheet.Cell(i, columnLetter - 'A' + 1).Value.ToString();

                                if (!cellValue.All(char.IsDigit) && cellValue != "NULL")
                                {
                                    cellValue = $"'{cellValue}'";
                                }

                                currentSql = currentSql.Replace(placeholder, cellValue);
                            }
                        }

                        sqlBuilder.AppendLine(currentSql);
                        sqlBuilder.AppendLine(separator);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar scripts" + Environment.NewLine + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(sqlBuilder.ToString());
            MessageBox.Show("Script gerado com sucesso e copiado para a área de transferência.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}