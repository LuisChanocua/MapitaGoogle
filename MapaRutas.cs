using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//librerias para el mapa
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace MapitaGoogle
{
    public partial class form_MapaRutas : Form
    {
        GMarkerGoogle marker;
        //GMapMarker marker;
        GMapOverlay overlay;
        DataTable dt;

        int fselec = 0;

        double lati = 18.6233886747509;
        double loni = -100.90016583986068;


        public form_MapaRutas()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Desc",typeof(String)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //insertamos dato al data gred
            dt.Rows.Add("Ubicacion",lati,loni);
            dtg_paradas_m.DataSource = dt;

            //desactivar columnas
            dtg_paradas_m.Columns[1].Visible = false;
            dtg_paradas_m.Columns[2].Visible = false;

            gmc_mr.DragButton = MouseButtons.Left;
            gmc_mr.CanDragMap = true;
            gmc_mr.MapProvider = GMapProviders.GoogleMap;
            gmc_mr.Position = new PointLatLng(lati, loni);
            gmc_mr.MinZoom = 0;
            gmc_mr.MaxZoom = 24;
            gmc_mr.Zoom = 9;
            gmc_mr.AutoScroll = true;

            overlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(lati, loni), GMarkerGoogleType.green_big_go);

            overlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ubicacion: \n LAt:{0} \n Lon:{1}",lati,loni);
            
            //agregamos el overlay
            gmc_mr.Overlays.Add(overlay);
        }
    }
}
