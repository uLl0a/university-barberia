#pragma checksum "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f37e87bcb0ba5499cd136cf8a46b1a83619da939"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Factura/generar")]
    public partial class Factura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "no-print");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content");
            __builder.AddMarkupContent(4, "<label class=\"form-label\" for=\"form2Example17\">Selecciona un cliente</label>\r\n        ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "name", "cliente");
            __builder.AddAttribute(7, "id", "cliente");
            __builder.AddAttribute(8, "required");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                   cliente_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente_id = __value, cliente_id));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 10 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
             for (int i = 0; i < Clientes.Count; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "label", 
#nullable restore
#line 12 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                               Clientes[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 12 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                  i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content");
            __builder.AddMarkupContent(17, "<label class=\"form-label\" for=\"form2Example17\">Selecciona un servicio</label>\r\n        ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "name", "prod");
            __builder.AddAttribute(20, "id", "prod");
            __builder.AddAttribute(21, "required");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                             servicio_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => servicio_id = __value, servicio_id));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 19 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
             for (int i = 0; i < Servicios.Count; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "label", 
#nullable restore
#line 21 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                               Servicios[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 21 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                   i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                  AgregarServicios

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn bg-green btn-light mx-1px text-95");
            __builder.AddAttribute(31, "href", "#");
            __builder.AddAttribute(32, "data-title", "Print");
            __builder.AddMarkupContent(33, "                    Agregar servicio\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "content");
            __builder.AddMarkupContent(37, "<label for=\"date\">Fecha de facturacion</label>\r\n        ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "datetime");
            __builder.AddAttribute(40, "name", "date");
            __builder.AddAttribute(41, "id", "date");
            __builder.AddAttribute(42, "required");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                            fecha

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha = __value, fecha));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "content");
            __builder.AddMarkupContent(48, "<label class=\"form-label\" for=\"form2Example17\">Selecciona el estado de la factura</label>\r\n        ");
            __builder.OpenElement(49, "select");
            __builder.AddAttribute(50, "name", "estado_fac");
            __builder.AddAttribute(51, "id", "estado_fac");
            __builder.AddAttribute(52, "required");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                         estado_factura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => estado_factura = __value, estado_factura));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 36 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
             for (int i = 0; i < Estadodefactura.Count; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "label", 
#nullable restore
#line 38 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                               Estadodefactura[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 38 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                         i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "page-tools");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "action-buttons");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                  Generar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "href", "#");
            __builder.AddAttribute(66, "class", "btn btn-info btn-bold px-4 float-right mt-3 mt-lg-0");
            __builder.AddContent(67, "Generar Factura");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n<link rel=\"stylesheet\" href=\"css/factura.css\">\r\n<link rel=\"stylesheet\" href=\"css/ViewReport.css\">\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "container myDivToPrint");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "page-content container");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "page-header text-blue-d2");
            __builder.OpenElement(75, "h1");
            __builder.AddAttribute(76, "class", "page-title text-secondary-d1");
            __builder.AddMarkupContent(77, "\r\n            Factura\r\n            ");
            __builder.OpenElement(78, "small");
            __builder.AddAttribute(79, "class", "page-info");
            __builder.AddMarkupContent(80, "<i class=\"fa fa-angle-double-right text-80\"></i>\r\n                ID: #");
            __builder.AddContent(81, 
#nullable restore
#line 58 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                      TotalFacturas

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "container px-0");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row mt-4");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-12 col-lg-12");
            __builder.AddMarkupContent(89, @"<div class=""row""><div class=""col-12""><div class=""text-center text-150""><i class=""fa fa-book fa-2x text-success-m2 mr-1""></i>
                            <img src=""/img/th-2281550830.jpg"" width=""200"" height=""200""></div></div></div>
                

                <hr class=""row brc-default-l1 mx-n1 mb-4"">

                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-sm-6");
            __builder.OpenElement(94, "div");
            __builder.AddMarkupContent(95, "<span class=\"text-sm text-grey-m2 align-middle\">To:</span>\r\n                            ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "text-600 text-110 text-blue align-middle");
            __builder.AddContent(98, 
#nullable restore
#line 82 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                    Clientes[cliente_id]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "text-grey-m2");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "my-1");
            __builder.AddContent(104, 
#nullable restore
#line 86 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                 ClientesDirecciones[cliente_id]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "my-1");
            __builder.AddMarkupContent(108, "<i class=\"fa fa-phone fa-flip-horizontal text-secondary\"></i> ");
            __builder.OpenElement(109, "b");
            __builder.AddAttribute(110, "class", "text-600");
            __builder.AddContent(111, 
#nullable restore
#line 88 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                                                                 ClientesTelefonos[cliente_id]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    \r\n\r\n                    ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "text-95 col-sm-6 align-self-start d-sm-flex justify-content-end");
            __builder.AddMarkupContent(115, "<hr class=\"d-sm-none\">\r\n                        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "text-grey-m2");
            __builder.AddMarkupContent(118, "<div class=\"mt-1 mb-2 text-secondary-m1 text-600 text-125\">\r\n                                Factura \r\n                            </div>\r\n\r\n                            ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "my-2");
            __builder.AddMarkupContent(121, "<i class=\"fa fa-circle text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(122, "<span class=\"text-600 text-90\">ID:</span> #");
            __builder.AddContent(123, 
#nullable restore
#line 100 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                                                                                 TotalFacturas

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n                            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "my-2");
            __builder.AddMarkupContent(127, "<i class=\"fa fa-circle text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(128, "<span class=\"text-600 text-90\">Fecha de facturacion:</span> ");
            __builder.AddContent(129, 
#nullable restore
#line 102 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                                                                                                  fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n                            ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "my-2");
            __builder.AddMarkupContent(133, "<i class=\"fa fa-circle text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(134, "<span class=\"text-600 text-90\">Status:</span> ");
            __builder.OpenElement(135, "span");
            __builder.AddAttribute(136, "class", "badge badge-warning badge-pill px-25");
            __builder.AddContent(137, 
#nullable restore
#line 104 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                                                                                                                                       Estadodefactura[estado_factura]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n             ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "mt-4");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "table-responsive");
            __builder.OpenElement(143, "table");
            __builder.AddAttribute(144, "class", "table table-striped table-borderless border-0 border-b-2 brc-default-l1");
            __builder.AddMarkupContent(145, "<thead class=\"bg-none bgc-default-tp1\"><tr class=\"text-white\"><th class=\"opacity-2\">#</th>\r\n                            <th>Descripcion</th>\r\n                            <th width=\"140\">Monto</th></tr></thead>\r\n                    ");
            __builder.OpenElement(146, "tbody");
            __builder.AddAttribute(147, "class", "text-95 text-secondary-d3");
#nullable restore
#line 122 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                         foreach (int item in ServiciosPorFacturar)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(148, "<tr></tr>\r\n                        ");
            __builder.OpenElement(149, "tr");
            __builder.OpenElement(150, "td");
            __builder.AddContent(151, 
#nullable restore
#line 126 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                 ServiciosID[item]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                            ");
            __builder.OpenElement(153, "td");
            __builder.AddContent(154, 
#nullable restore
#line 127 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                 Servicios[item]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                            ");
            __builder.OpenElement(156, "td");
            __builder.AddAttribute(157, "class", "text-95");
            __builder.AddContent(158, 
#nullable restore
#line 128 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                 ServiciosPrecios[item]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "row mt-3");
            __builder.AddMarkupContent(162, "<div class=\"col-12 col-sm-7 text-grey-d2 text-95 mt-2 mt-lg-0\"></div>\r\n                        ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "col-12 col-sm-5 text-grey text-90 order-first order-sm-last");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "row my-2 align-items-center bgc-primary-l3 p-2");
            __builder.AddMarkupContent(167, "<div class=\"col-7 text-right\">\r\n                                     Monto total\r\n                                </div>\r\n                                ");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "col-5");
            __builder.OpenElement(170, "span");
            __builder.AddAttribute(171, "class", "text-150 text-success-d3 opacity-2");
            __builder.AddContent(172, "$");
            __builder.AddContent(173, 
#nullable restore
#line 143 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
                                                                                       monto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n\r\n                    <hr>\r\n\r\n                    ");
            __builder.AddMarkupContent(175, "<div><span class=\"text-secondary-d1 text-105\">Gracias por visitar nuestra peluqueria</span></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "C:\Users\University\Documents\Universidad\Septimo trimestre\INGENIERIA DE SOFTWARE II\PROYECTO FINAL\SISTEMA\Pages\Factura.razor"
      
    int cliente_id = 0;
    int servicio_id = 0;
    int estado_factura = 0;
    DateTime fecha;
    int TotalFacturas;
    int monto;
    
    System.Collections.ArrayList Clientes = new System.Collections.ArrayList();
    System.Collections.ArrayList Servicios = new System.Collections.ArrayList();
    System.Collections.ArrayList ServiciosID = new System.Collections.ArrayList();
    System.Collections.ArrayList ServiciosPrecios = new System.Collections.ArrayList();
    System.Collections.ArrayList ClientesDirecciones = new System.Collections.ArrayList();
    System.Collections.ArrayList ClientesTelefonos = new System.Collections.ArrayList();
    System.Collections.ArrayList Estadodefactura = new System.Collections.ArrayList();
    System.Collections.ArrayList ServiciosPorFacturar = new System.Collections.ArrayList();

    public void imprimir(){
        js.InvokeVoidAsync("print");
    }

    public void AgregarServicios(){
        ServiciosPorFacturar.Add(servicio_id);
        monto += Int32.Parse(ServiciosPrecios[servicio_id].ToString());
    }

    void Generar(){
        if(ServiciosPorFacturar == null || monto == 0){
            return;
        }

        try{
            MySqlCommand command = new MySqlCommand("INSERT INTO Factura(codigo,cliente,estado) VALUES (@m_codigo,@m_cliente,@m_estado);");
            command.Parameters.AddWithValue("@m_codigo",TotalFacturas);
            command.Parameters.AddWithValue("@m_cliente",cliente_id + 1);
            command.Parameters.AddWithValue("@m_estado",estado_factura + 1);

            if(dbaccess.ExecuteQuery(command) != -1){
                Console.WriteLine("Factura registrada correctamente");
            }
        }catch{
            Console.WriteLine("Error al momento de registrar la factura");
        }

        imprimir();
    }

    protected async override Task OnInitializedAsync()
    {
        Clientes = dbaccess.GetListFromDataBase("SELECT nombre FROM Clientes;","nombre");
        ClientesDirecciones = dbaccess.GetListFromDataBase("SELECT direccion FROM Clientes","direccion");
        ClientesTelefonos = dbaccess.GetListFromDataBase("SELECT telefono FROM Clientes", "telefono");
        ServiciosPrecios = dbaccess.GetListFromDataBase("SELECT precio FROM Servicios;","precio");
        Servicios = dbaccess.GetListFromDataBase("SELECT servicio AS descripcion FROM Servicios;","descripcion");
        ServiciosID = dbaccess.GetListFromDataBase("SELECT codigo FROM Servicios;","codigo");
        Estadodefactura = dbaccess.GetListFromDataBase("SELECT nombre FROM EstadoFactura;","nombre");
        MySql.Data.MySqlClient.MySqlDataReader tmp = dbaccess.ReadDataThroughtReader("SELECT COUNT(*) AS CANTIDAD FROM Factura");
        while(tmp.Read()){ TotalFacturas = Int32.Parse(tmp["CANTIDAD"].ToString()); TotalFacturas += 1; }
        tmp.Close();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
