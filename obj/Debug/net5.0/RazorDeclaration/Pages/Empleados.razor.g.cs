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
#line 2 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Empleados.razor"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Empleados.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Empleados")]
    public partial class Empleados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Empleados.razor"
      
    bool AddMode = false;
    bool EditMode = false;
    System.Data.DataTable EmpleadosTable = new System.Data.DataTable();
    System.Collections.ArrayList Estados = new ArrayList();
    System.Collections.ArrayList Cargos = new ArrayList();
    int empleado_id;
    string nombre_completo;
    string cedula;
    string telefono;
    string celular;
    string email;
    string direccion;
    DateTime fecha;
    int cargo;
    int estado;

    void ChangeStateToAddMode(){
        AddMode = !AddMode;
    }

    void CancelarModo(){
        AddMode = false;
        EditMode = false;
    }
    void ChangeStateToEditMode(){
        if(empleado_id <= 0){
            return;
        }
        try{
            System.Data.DataTable table = dbaccess.ReadDataThroughtAdapter($"SELECT * FROM Empleados WHERE id = {empleado_id}");
            nombre_completo = table.Rows[0]["nombre"].ToString();
            cedula = table.Rows[0]["cedula"].ToString();
            telefono = table.Rows[0]["telefono"].ToString();
            celular = table.Rows[0]["celular"].ToString();
            email = table.Rows[0]["email"].ToString();
            direccion = table.Rows[0]["direccion"].ToString();
            fecha = DateTime.Parse(table.Rows[0]["fecha_inicio"].ToString());
            estado = (int)Convert.ChangeType(table.Rows[0]["estado"].ToString(),(typeof(int)));
            cargo = (int)Convert.ChangeType(table.Rows[0]["cargo"].ToString(),(typeof(int)));
            AddMode = !AddMode;
            EditMode = !EditMode;
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

    protected async override Task OnInitializedAsync(){
        try{
            EmpleadosTable = dbaccess.ReadDataThroughtAdapter("SELECT Empleados.id AS ID, Empleados.cedula AS Cedula, Empleados.nombre AS 'Nombre completo', Empleados.telefono AS Telefono, Empleados.celular AS Celular, Empleados.email AS Email,Cargos.cargo AS Cargo, Estadosnomina.nombre AS Estado, Empleados.direccion AS Direccion, fecha_inicio AS 'Fecha de ingreso' FROM Empleados, Estadosnomina, Cargos WHERE Empleados.cargo = Cargos.id AND Empleados.estado = Estadosnomina.id;");
            Cargos = dbaccess.GetListFromDataBase("SELECT cargo FROM Cargos;", "cargo");
            Estados = dbaccess.GetListFromDataBase("SELECT nombre FROM Estadosnomina;", "nombre");
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

    void FindClient(){
        if(empleado_id <= 0){
            return;
        }
        try{
            EmpleadosTable = dbaccess.ReadDataThroughtAdapter($"SELECT Empleados.id AS ID, Empleados.cedula AS Cedula, Empleados.nombre AS 'Nombre completo', Empleados.telefono AS Telefono, Empleados.celular AS Celular, Empleados.email AS Email,Cargos.cargo AS Cargo, Estadosnomina.nombre AS Estado, Empleados.direccion AS Direccion, fecha_inicio AS 'Fecha de ingreso' FROM Empleados, Estadosnomina, Cargos WHERE Empleados.cargo = Cargos.id AND Empleados.estado = Estadosnomina.id AND Empleados.id = {empleado_id};");
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }

    void SubmitClient(){
        if(nombre_completo == "" || telefono == "" || celular == "" || email == "" || direccion == "" || cargo <= 0 || estado <= 0){
            return;
        }

        try{
            MySqlCommand command = new MySqlCommand("INSERT INTO Empleados(cedula,nombre,telefono,celular,email,fecha_inicio,direccion,estado,cargo) VALUES (@m_cedula,@m_nombre_completo,@m_telefono,@m_celular,@m_email,@m_fecha,@m_direccion,@m_estado,@m_cargo)");
            command.Parameters.AddWithValue("@m_cedula",cedula);
            command.Parameters.AddWithValue("@m_nombre_completo",nombre_completo);
            command.Parameters.AddWithValue("@m_telefono",telefono);
            command.Parameters.AddWithValue("@m_celular",celular);
            command.Parameters.AddWithValue("@m_email",email);
            command.Parameters.AddWithValue("@m_fecha",fecha);
            command.Parameters.AddWithValue("@m_direccion",direccion);
            command.Parameters.AddWithValue("@m_estado",estado);
            command.Parameters.AddWithValue("@m_cargo",cargo);

            if(dbaccess.ExecuteQuery(command) != -1){
                Console.WriteLine("Cita registrada correctamente");
            }
        }catch{
            Console.WriteLine("Error al momento de registrar la cita");
        } 
    AddMode = !AddMode;

    }

    void UpdateClient(){
        if(nombre_completo == "" || telefono == "" || celular == "" || email == "" || direccion == ""){
            return;
        }

        try{
            MySqlCommand command = new MySqlCommand("UPDATE Empleados SET cedula=@m_cedula, nombre=@m_nombre_completo, telefono=@m_telefono, celular=@m_celular,email=@m_email, fecha_inicio=@m_fecha, direccion=@m_direccion, estado=@m_estado, cargo=@m_cargo WHERE id=@m_id;");
            command.Parameters.AddWithValue("@m_cedula",cedula);
            command.Parameters.AddWithValue("@m_nombre_completo",nombre_completo);
            command.Parameters.AddWithValue("@m_telefono",telefono);
            command.Parameters.AddWithValue("@m_celular",celular);
            command.Parameters.AddWithValue("@m_email",email);
            command.Parameters.AddWithValue("@m_fecha",fecha);
            command.Parameters.AddWithValue("@m_direccion",direccion);
            command.Parameters.AddWithValue("@m_estado",estado);
            command.Parameters.AddWithValue("@m_cargo",cargo);
            command.Parameters.AddWithValue("@m_id",empleado_id);

            if(dbaccess.ExecuteQuery(command) != -1){
                Console.WriteLine("Cita registrada correctamente");
            }
        }catch{
            Console.WriteLine("Error al momento de registrar la cita");
        } 
    AddMode = !AddMode;
    EditMode = !EditMode;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
