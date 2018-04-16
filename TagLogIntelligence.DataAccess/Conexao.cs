using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLogIntelligence.Domain;

namespace TagLogIntelligence.DataAccess
{
    public class Conexao : DbContext
    {

        //Colocar no Web.Config

        public Conexao() : base(@"Data Source=AV-T460-8200\SQLEXPRESS;Initial Catalog=TagLogIntelligence;Integrated Security=True")
        //ConfigurationManager.AppSettings["DEFAULT"]
        //Data Source=SERGIORAMOS;Initial Catalog=TagLogIntelligence;Integrated Security=True
        //base(@"Data Source=AV-T460-8200\SQLEXPRESS;Initial Catalog=TagLogIntelligence;Integrated Security=True")
        {
        }
        public virtual DbSet<ARQUIVO_VIP> ArquivoVips { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
         

    }
}

