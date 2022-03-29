using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства: \n \n Text: определяет заголовок формы \n" +
                "Name: устанавливает имя формы - точнее имя класса, который наследуется от класса Form \n" +
                "BackColor: указывает на фоновый цвет формы. Щелкнув на это свойство, мы сможем выбрать тот цвет, который нам подходит из списка предложенных цветов или цветовой палитры \n" +
                "Font: задает шрифт для всей формы и всех помещенных на нее элементов управления. Однако, задав у элементов формы свой шрифт, мы можем тем самым переопределить его \n" +
                "Size: определяет начальный размер формы \n \n" +
                "Методы: \n \n" +
                "Activate() Активирует форму и перемещает на нее фокус. \n" +
                "CenterToScreen() Выравнивает форму по центру текущего экрана. \n" +
                "Close() Закрывает форму.\n \n Далее нажмите на 'инструкции компонентов' "; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "Компонент SaveFileDialog - Служит для выбора сохраняемых файлов и места их сохранения. \n \n Основные свойства: \n \n 1) CreatePrompt: при значении true в случае, если указан не существующий файл, то будет отображаться сообщение о его создании \n 2) OverwritePrompt: при значении true в случае, если указан существующий файл, то будет отображаться сообщение о том, что файл будет перезаписан \n 3) Filter: задает фильтр файлов, благодаря чему в диалоговом окне можно отфильтровать файлы по расширению.";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Компонент OpenFileDialog - Позволяет пользователям открывать файлы в стандартном диалоговом окне. \n \n Основные свойства: \n \n 1) DefaultExt: устанавливает расширение файла, которое добавляется по умолчанию, если пользователь ввел имя файла без расширения \n 2) OverwritePrompt: при значении true в случае, если указан существующий файл, то будет отображаться сообщение о том, что файл будет перезаписан \n 3) nitialDirectory: устанавливает каталог, который отображается при первом вызове окна \n \n";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Компонент SaveFileDialog - Служит для выбора сохраняемых файлов и места их сохранения.\n \n Основные свойства: \n \n 1) CreatePrompt: при значении true в случае, если указан не существующий файл, то будет отображаться сообщение о его создании \n 2) OverwritePrompt: при значении true в случае, если указан существующий файл, то будет отображаться сообщение о том, что файл будет перезаписан \n 3) Filter: задает фильтр файлов, благодаря чему в диалоговом окне можно отфильтровать файлы по расширению.\n \n Компонент OpenFileDialog - Позволяет пользователям открывать файлы в стандартном диалоговом окне. \n \n Основные свойства: \n \n 1) DefaultExt: устанавливает расширение файла, которое добавляется по умолчанию, если пользователь ввел имя файла без расширения \n 2) OverwritePrompt: при значении true в случае, если указан существующий файл, то будет отображаться сообщение о том, что файл будет перезаписан \n 3) nitialDirectory: устанавливает каталог, который отображается при первом вызове окна \n \n Нажмите на кнопки с названиями компонентов, чтобы увидеть их в работе";
        }
    }
}
