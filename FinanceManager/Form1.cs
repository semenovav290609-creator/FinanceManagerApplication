using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Web.Script.Serialization; // Заменили встроенную библиотеку JSON на стандартную для .NET Framework

namespace FinanceManager
{
    public partial class Form1 : Form
    {
        // Подключаем системную функцию Windows для красивой подсказки в TextBox
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string filePath = "finance_data.json";

        // Переменные для хранения данных
        private int balance = 0;
        private int totalSp = 0;
        private List<string> categories = new List<string>()
        {
            "Продукты", "Кафе и рестораны", "Транспорт", "Жилье и ЖКХ",
            "Здоровье и аптека", "Одежда и обувь", "Развлечения",
            "Техника", "Подарки", "Прочее"
        };

        // Специальный класс-модель для удобной упаковки данных в JSON
        public class FinanceSaveModel
        {
            public int CurrentBalance { get; set; }
            public int TotalSpent { get; set; }
            public List<TransactionModel> Transactions { get; set; } = new List<TransactionModel>();
        }

        // Модель для отдельной транзакции
        public class TransactionModel
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Category { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromJson(); // Загружаем данные из JSON

            lblBalance.Text = $"Общий баланс: {balance}₽";
            totalSpent.Text = $"Итого потрачено: {totalSp}.00 ₽";

            // Настройка колонок для режима Tile
            listViewTransactions.Columns.Add("Название", 150);
            listViewTransactions.Columns.Add("Цена", 100);
            listViewTransactions.Columns.Add("Категория", 150);

            // Включаем водяной знак для поля названия
            SendMessage(textBoxName.Handle, 0x1501, 1, "Название");

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(categories.ToArray());

            comboBoxCategory.SelectedIndex = -1;
            comboBoxCategory.Text = "Категория";
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            int currentSpending = (int)numericUpDownPrice.Value;

            if (currentSpending <= 0)
            {
                MessageBox.Show("Введите сумму траты больше нуля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxCategory.SelectedIndex == -1 || comboBoxCategory.Text == "Категория")
            {
                MessageBox.Show("Пожалуйста, выберите категорию траты!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            balance -= currentSpending;
            totalSp += currentSpending;

            lblBalance.Text = $"Общий баланс: {balance}₽";
            totalSpent.Text = $"Итого потрачено: {totalSp}.00 ₽";

            string spendingName = string.IsNullOrWhiteSpace(textBoxName.Text) ? "Без названия" : textBoxName.Text;

            ListViewItem item = new ListViewItem(spendingName);
            item.SubItems.Add($"-{currentSpending} ₽ Дата: [{DateTime.Now.ToString("dd.MM.yyyy")}]");

            item.UseItemStyleForSubItems = false;
            item.SubItems[1].ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            item.SubItems[1].Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            item.SubItems.Add(comboBoxCategory.Text);
            listViewTransactions.Items.Add(item);

            numericUpDownPrice.Value = 0;
            textBoxName.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            comboBoxCategory.Text = "Категория";
        }
        private void btnIncomeBlance_Click(object sender, EventArgs e)
        {
            // 1. Получаем сумму дохода
            int curentIncome = (int)numericUpDownIncome.Value;

            // Проверка: если ввели 0 или меньше, ничего не делаем
            if (curentIncome <= 0)
            {
                MessageBox.Show("Введите сумму дохода больше нуля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Математически ПРИБАВЛЯЕМ доход к балансу
            balance = balance + curentIncome; // или balance += curentIncome;

            // 3. ПЕРЕЗАПИСЫВАЕМ текст на экране (используем =, а не +=)
            lblBalance.Text = $"Общий баланс: {balance}₽";

            // 4. Сбрасываем поле ввода дохода на ноль
            numericUpDownIncome.Value = 0;
        }

        private void btnDelAllTransaction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите полностью очистить историю?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // 1. Очищаем визуальный список (таблицу) на форме
                listViewTransactions.Items.Clear();                               

                // 3. ОЧИЩАЕМ ФАЙЛ ДО АБСОЛЮТНОЙ ПУСТОТЫ
                string jsonFilePath = "finance_data.json"; 

                try
                {
                    // Этот метод полностью стирает всё внутри файла, оставляя 0 байт текста
                    File.WriteAllText(jsonFilePath, string.Empty);

                    MessageBox.Show("Всё готово! И на экране, и в файле теперь идеальная пустота.", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при работе с файлом: {ex.Message}", "Ошибка");
                }
            }
        }

        // Автоматическое сохранение в JSON ПРИ ЗАКРЫТИИ программы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // 1. Создаем объект нашей модели и заполняем текущими данными
                FinanceSaveModel saveData = new FinanceSaveModel
                {
                    CurrentBalance = balance,
                    TotalSpent = totalSp
                };

                // 2. Собираем все транзакции из ListView в список объектов
                foreach (ListViewItem item in listViewTransactions.Items)
                {
                    saveData.Transactions.Add(new TransactionModel
                    {
                        Name = item.Text,
                        Price = item.SubItems[1].Text,
                        Category = item.SubItems[2].Text
                    });
                }

                // 3. Используем JavaScriptSerializer для превращения объекта в строку
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonString = serializer.Serialize(saveData);

                // 4. Записываем строку в файл
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении JSON: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для чтения данных из JSON ПРИ ЗАПУСКЕ программы
        private void LoadDataFromJson()
        {
            if (!File.Exists(filePath)) return; // Если файла нет, выходим

            try
            {
                // 1. Читаем весь текст из файла
                string jsonString = File.ReadAllText(filePath);

                // 2. Десериализуем (восстанавливаем данные)
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                FinanceSaveModel loadedData = serializer.Deserialize<FinanceSaveModel>(jsonString);

                if (loadedData != null)
                {
                    // 3. Распределяем данные по переменным
                    balance = loadedData.CurrentBalance;
                    totalSp = loadedData.TotalSpent;

                    // 4. Восстанавливаем транзакции на плитках
                    foreach (var tx in loadedData.Transactions)
                    {
                        ListViewItem item = new ListViewItem(tx.Name);
                        item.SubItems.Add(tx.Price);

                        item.UseItemStyleForSubItems = false;
                        item.SubItems[1].ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                        item.SubItems[1].Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

                        item.SubItems.Add(tx.Category);
                        listViewTransactions.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке JSON: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пустые методы для дизайнера (не удалять)
        private void lblBalance_Click(object sender, EventArgs e) { }
        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e) { }
        private void totalSpent_Click(object sender, EventArgs e) { }
        private void comboBoxCatigory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listViewTransactions_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_Enter(object sender, EventArgs e) { }
        private void textBoxName_TextChanged(object sender, EventArgs e) { }
        private void numericUpDownIncome_ValueChanged(object sender, EventArgs e) { }        
    }
}
