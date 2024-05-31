﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        static List<Aplicacion> appsInstaladas;
        static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(sistemaOperativo == app.SistemaOperativo)
            {
                return appsInstaladas + app;
            }

            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo: {sistemaOperativo}\n");
            sb.AppendLine($"Apps instaladas:\n");
            foreach (Aplicacion item in appsInstaladas)
            {
                sb.AppendLine(item.ObtenerInformacionApp());
            }

            return sb.ToString();
        }

    }
}
