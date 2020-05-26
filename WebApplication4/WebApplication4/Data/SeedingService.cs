using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Entidades;



namespace WebApplication4.Data
{
    public class SeedingService
    {
        private WebApplication4Context _Context;

            public SeedingService(WebApplication4Context context)
        {
            _Context = context;
        }
        public void Seed()
        {
            if (_Context.Departamento.Any() ||
                _Context.Vendedor.Any() ||
                _Context.Vendas.Any())
            {
                return;
            }
            Departamento D1 = new Departamento(001, "Sapatos");
            Departamento D2 = new Departamento(002, "Roupas");
            Departamento D3 = new Departamento(003, "Perfumaria");
            Departamento D4 = new Departamento(004, "Limpeza");
            Departamento D5 = new Departamento(005, "Alimentos");
            Departamento D6 = new Departamento(006, "Bebidas");

            Vendedor V1 = new Vendedor(001, "Joao da Silva", "joao@gmail.com", new DateTime(1970, 02, 15), 1500.00, D1);
            Vendedor V2 = new Vendedor(002, "Felipe Melo", "felipe@gmail.com", new DateTime(1980, 03, 25), 1850.00, D2);
            Vendedor V3 = new Vendedor(003, "Maria Aparecida dos Santos", "m.santos@gmail.com", new DateTime(1990, 12, 25), 3000.00, D3);
            Vendedor V4 = new Vendedor(004, "Jose Manoel da Silva", "jmsilva@gmail.com", new DateTime(2000, 09, 10), 5538.00, D4);
            Vendedor V5 = new Vendedor(005, "Mario Figueiredo", "mfigueiredo@gmail.com", new DateTime(1987, 04, 03), 3300.00, D5);
            Vendedor V6 = new Vendedor(006, "Maria Jose da Silveira", "mjsilveira@gmail.com", new DateTime(1993, 12, 20), 4500.00, D1);

            Vendas RV1 = new Vendas(001, new DateTime(2020, 01, 20), 300.50, Models.Status.Faturada, V1);
            Vendas RV2 = new Vendas(002, new DateTime(2020, 01, 23), 100.00, Models.Status.Faturada, V1);
            Vendas RV3 = new Vendas(003, new DateTime(2020, 01, 24), 398.00, Models.Status.Faturada, V1);
            Vendas RV4 = new Vendas(004, new DateTime(2020, 01, 25), 465.00, Models.Status.Faturada, V2);
            Vendas RV5 = new Vendas(005, new DateTime(2020, 01, 30), 165.80, Models.Status.Faturada, V2);
            Vendas RV6 = new Vendas(006, new DateTime(2020, 02, 03), 989.70, Models.Status.Faturada, V2);
            Vendas RV7 = new Vendas(007, new DateTime(2020, 02, 05), 1300.51, Models.Status.Faturada, V3);
            Vendas RV8 = new Vendas(008, new DateTime(2020, 01, 20), 300.50, Models.Status.Faturada, V3);
            Vendas RV9 = new Vendas(009, new DateTime(2020, 01, 23), 100.00, Models.Status.Faturada, V3);
            Vendas RV10 = new Vendas(010, new DateTime(2020, 01, 24), 398.00, Models.Status.Faturada, V3);
            Vendas RV11 = new Vendas(011, new DateTime(2020, 01, 25), 465.00, Models.Status.Faturada, V4);
            Vendas RV12 = new Vendas(012, new DateTime(2020, 01, 30), 165.80, Models.Status.Faturada, V4);
            Vendas RV13 = new Vendas(013, new DateTime(2020, 02, 03), 989.70, Models.Status.Faturada, V4);
            Vendas RV14 = new Vendas(014, new DateTime(2020, 02, 05), 1300.51, Models.Status.Faturada, V4);

            Vendas RV15 = new Vendas(015, new DateTime(2020, 03, 01), 330.50, Models.Status.Faturada, V5);
            Vendas RV16 = new Vendas(016, new DateTime(2020, 03, 02), 1100.00, Models.Status.Faturada, V5);
            Vendas RV17 = new Vendas(017, new DateTime(2020, 03, 03), 798.00, Models.Status.Faturada, V6);
            Vendas RV18 = new Vendas(018, new DateTime(2020, 03, 04), 333.00, Models.Status.Faturada, V6);
            Vendas RV19 = new Vendas(019, new DateTime(2020, 03, 05), 189.80, Models.Status.Faturada, V5);
            Vendas RV20 = new Vendas(020, new DateTime(2020, 03, 06), 69.90, Models.Status.Faturada, V1);
            Vendas RV21 = new Vendas(021, new DateTime(2020, 03, 07), 1425.00, Models.Status.Faturada, V5);
            Vendas RV22 = new Vendas(022, new DateTime(2020, 03, 12), 87.80, Models.Status.Faturada, V6);
            Vendas RV23 = new Vendas(023, new DateTime(2020, 03, 13), 199.00, Models.Status.Faturada, V3);
            Vendas RV24 = new Vendas(024, new DateTime(2020, 03, 14), 478.90, Models.Status.Faturada, V5);
            Vendas RV25 = new Vendas(025, new DateTime(2020, 03, 15), 890.00, Models.Status.Faturada, V2);
            Vendas RV26 = new Vendas(026, new DateTime(2020, 03, 30), 564.80, Models.Status.Faturada, V6);
            Vendas RV27 = new Vendas(027, new DateTime(2019, 02, 03), 200.20, Models.Status.Faturada, V5);
            Vendas RV28 = new Vendas(028, new DateTime(2019, 02, 05), 259.90, Models.Status.Faturada, V4);
            Vendas RV29 = new Vendas(029, new DateTime(2019, 02, 15), 879.00, Models.Status.Faturada, V3);
            Vendas RV30 = new Vendas(030, new DateTime(2019, 02, 28), 89.90, Models.Status.Faturada, V1);

            _Context.Departamento.AddRange(D1, D2, D3, D4, D5, D6);

            _Context.Vendedor.AddRange(V1, V2, V3, V4, V5, V6);

            _Context.Vendas.AddRange(RV1, RV2, RV3, RV4, RV5, RV6, RV7, RV8, RV9, RV10,
                                     RV11, RV12, RV13, RV14, RV15, RV16, RV17, RV18, RV19, RV20,
                                     RV21, RV22, RV23, RV24, RV25, RV26, RV27, RV28, RV29, RV30);

            _Context.SaveChanges();
        }
    }


}
