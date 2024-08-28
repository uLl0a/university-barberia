// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SISTEMA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using SISTEMA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\_Imports.razor"
using SISTEMA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\FacturaHistorial.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\FacturaHistorial.razor"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Factura/historial")]
    public partial class FacturaHistorial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\FacturaHistorial.razor"
       
    bool AddMode = false;
    bool EditMode = false;
    System.Data.DataTable FacturaTable = new System.Data.DataTable();
    System.Collections.ArrayList Estados = new ArrayList();
    int factura_id;
    int estado;

    void ChangeStateToAddMode(){
        AddMode = !AddMode;
    }

    void ChangeStateToEditMode(){
        if(factura_id <= 0){
            return;
        }
        try{
            System.Data.DataTable table = dbaccess.ReadDataThroughtAdapter($"SELECT * FROM Factura WHERE codigo = {factura_id}");
            estado = (int)Convert.ChangeType(table.Rows[0]["estado"].ToString(), (typeof(int)));
            AddMode = !AddMode;
            EditMode = !EditMode;
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

    void CancelarModo(){
        AddMode = false;
        EditMode = false;
    }

    void UpdateTipoDeServicio()
    {
        if(factura_id <= 0 || estado <= 0){
            return;
        }

        try{
            MySqlCommand command = new MySqlCommand("UPDATE Factura SET estado=@m_estado WHERE codigo=@m_id;");
            command.Parameters.AddWithValue("@m_estado",estado);
            command.Parameters.AddWithValue("@m_id",factura_id);

            if(dbaccess.ExecuteQuery(command) != -1){
                Console.WriteLine("Servicio registrada correctamente");
            }
        }catch{
            Console.WriteLine("Error al momento de registrar la Servicio");
        } 
        AddMode = !AddMode;
        EditMode = !EditMode;
    }

    void FindServicio(){
        try{
            FacturaTable = dbaccess.ReadDataThroughtAdapter($"SELECT Factura.codigo AS 'Numero de factura', Clientes.nombre AS Cliente, EstadoFactura.nombre FROM Clientes, EstadoFactura, Factura WHERE Clientes.id = Factura.cliente AND EstadoFactura.id = Factura.estado AND Factura.codigo={factura_id}");
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

    protected async override Task OnInitializedAsync(){
        try{
            FacturaTable = dbaccess.ReadDataThroughtAdapter("SELECT Factura.codigo AS 'Numero de factura', Clientes.nombre AS Cliente, EstadoFactura.nombre AS 'Estado de la factura' FROM Clientes, EstadoFactura, Factura WHERE Clientes.id = Factura.cliente AND EstadoFactura.id = Factura.estado");
            Estados = dbaccess.GetListFromDataBase("SELECT nombre FROM EstadoFactura;", "nombre");
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
