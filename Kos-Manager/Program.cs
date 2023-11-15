using Kos_Manager.Matéria_prima;
using Kos_Manager.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{

    public static class Fornecedor
    {
        public static string Nome { get; set; }
        public static string Produto { get; set; }
        public static string Contato { get; set; }
        public static string Outro { get; internal set; }
    }

    public static class Manu
    {
        public static string nome { get; set; }
        public static DateTime datafab { get; set; }
        public static DateTime dataval { get; set; }
        public static string lote { get; set; }
        public static string quantidade { get; internal set; }
    }

    public static class Prima

        {

   
        public static string nomenclatura { get; set; }


        public static string lote { get; set; }

        public static DateTime dtval { get; set; }


        public static string quantidade { get; set; }

        public static string marca { get; set; }


        public static int fornecedorID { get; internal set; }

    }
        
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_inicial());
        }
    }
}
