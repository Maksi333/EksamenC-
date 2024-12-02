using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context {
    internal class EksamensInit : CreateDatabaseIfNotExists<EksamensContext>{
        protected override void Seed(EksamensContext context) {
            //todo initialize stuff

            context.SaveChanges();
        }
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
