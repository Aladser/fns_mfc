using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FNS_MFC
{
    internal static class Program
    {
        public static readonly string[] UNITS = {
            "MFC2-1",// Офис 1
            "MFC2-2",// Офис 2
            "MFC2-3",// Офис 3 
            "MFC12", // Архара
            "MFC21", // Бурея
            "MFC24", // Прогресс
            "MFC09", // Константиновка
            "MFC16", // Магдагачи
            "MFC17", // Новокиевский Увал
            "MFC11", // Поярково
            "MFC18", // Екатеринославка
            "MFC19", // Ромны
            "MFC20", // Серышево
            "MFC22", // Сковородино
            "MFC08", // Тамбовка
            "MFC14", // Зея
            "MFC13", // Райчихинск
            "MFC07", // Тында
            "MFC03", // Завитинск
            "MFC04", // Ивановка
            "MFC05", // Свободный
            "MFC10", // Белогорск
            "MFC15", // Февральск
            "MFC25", // Циолковский
            "MFC06", // Шимановск
        };
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
