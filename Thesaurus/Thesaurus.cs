using CRUD;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesaurus
{
    public partial class Thesaurus : Form
    {
        public Thesaurus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение дерева понятий
        /// </summary>
        /// <param name="code">Код понятия</param>
        private async void FillTreeNode(string code)
        {
            // Удаление всех узлов дерева
            thesaurusView.Nodes.Clear();

            // Объявление дерева
            TreeNode node = null;

            // Асинхронный чтение дерева
            await Task.Run(() => { node = NewNode(code); });

            // Добавление дерева
            thesaurusView.Nodes.Add(node);
        }

        /// <summary>
        /// Получение нового узла дерева
        /// </summary>
        /// <param name="parentCode">Код родительского понятия</param>
        /// <returns>Узел дерева</returns>
        private TreeNode NewNode(string parentCode)
        {
            // Получение наименования родительского понятия
            var parentName = GetNameByCode(parentCode);

            // Создание узла родительского понятия
            var treeNode = new TreeNode(parentName);

            // Запоминание кода родительского понятия
            treeNode.Tag = parentCode;

            // Получение кодов подчиненных понятий
            var childCodes = GetСhildren(parentCode);

            // Перебор кодов подчиненных понятий
            foreach (var childCode in childCodes)
            {
                // Создание узлов подчиенных понятий
                treeNode.Nodes.Add(NewNode(childCode));
            }

            // Возврат узла родительского понятия
            return treeNode;
        }

        /// <summary>
        /// Получение наименования понятия
        /// </summary>
        /// <param name="code">Код понятия</param>
        /// <returns>Наименование понятия</returns>
        private string GetNameByCode(string code)
        {
            // Объявление атрибутов поиска
            var attributes = new List<Attribute>();
            attributes.Add(new Attribute("Наименование", false));

            // Объявление атрибутов условия
            var condition = new List<Attribute>();
            condition.Add(new Attribute("Код", true, code));

            // Получение названия понятия по коду
            var result = new Database(Program.databasePath).Read(MyRelation.Dictionary, condition, attributes);

            // Возврат наименования понятия
            return result[0][0].Value;
        }

        /// <summary>
        /// Получение кодов подчиненных понятий
        /// </summary>
        /// <param name="code">Код основного понятий</param>
        /// <returns>Список кодов подчиненных понятий</returns>
        private List<string> GetСhildren(string code)
        {
            // Объявление атрибутов поиска
            var attributes = new List<Attribute>();
            attributes.Add(new Attribute("Код подчиненного понятия", true));

            // Объявление атрибутов условия
            var condition = new List<Attribute>();
            condition.Add(new Attribute("Код основного понятия", true, code));

            // Получение результата запроса
            var result = new Database(Program.databasePath).Read(MyRelation.Thesaurus, condition, attributes);

            // Получение кодов подчиненных понятий
            var codes = new List<string>();

            // Перебор кодов подчиненных понятий
            foreach (var record in result)
            {
                // Добавление кода
                codes.Add(record[0].Value);
            }

            // Возврат списка кодов подчиненных понятий
            return codes;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Прочитать понятия"
        /// </summary>
        private void Download_Click(object sender, System.EventArgs e)
        {
            FillTreeNode("00000001");
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Узнать код понятия"
        /// </summary>
        private void GetCode_Click(object sender, System.EventArgs e)
        {
            // Пример получение кода выбранного понятия
            var code = thesaurusView.SelectedNode.Tag as string;
            MessageBox.Show(code);
        }
    }
}
