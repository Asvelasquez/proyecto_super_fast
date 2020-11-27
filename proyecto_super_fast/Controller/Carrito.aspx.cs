using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Carrito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        //foreach (var a in lista5)
        //{
        //    try
        //    {
        //        suma = a.Precio_pedido + double.Parse(TBX_total2.Text);
        //    }catch(Exception exx)
        //    {

        //    }
        //    //TextBox1.Text = Convert.ToString(suma);

        //}

        ////TBX_total2.Text = double.Parse( c);

        //Console.ReadKey();
        TBX_subtotal1.Text = "0";
        mostrardatosentrega();
        mostrarpreciototal();
        mostrarpreciodomicilio();
       
    }

    protected void DL_pedido_ItemCommand(object source, DataListCommandEventArgs e){
        DL_pedido.SelectedIndex = e.Item.ItemIndex;
        DAOPedido daopedido6 = new DAOPedido();
        Pedido pedido7 = new Pedido();
        pedido7.Id_pedido= int.Parse(e.CommandArgument.ToString());
        Detalle_pedido det_pedido = new Detalle_pedido();

        if (e.CommandName == "Comprar")
        {

            det_pedido.Id_dpedido = int.Parse(e.CommandArgument.ToString());
            det_pedido.Cantidad = int.Parse(((TextBox)DL_pedido.SelectedItem.FindControl("TBX_cantidad")).Text);
            det_pedido.Direccion_cliente = ((TextBox)DL_pedido.SelectedItem.FindControl("TBX_direccion")).Text;
            det_pedido.Telefono_cliente = ((TextBox)DL_pedido.SelectedItem.FindControl("TBX_telefono")).Text;
            daopedido6.comprarproducto(pedido7);
            DL_pedido.DataBind();

        }
        else if (e.CommandName == "Eliminar")
        {
            daopedido6.deletepedido(pedido7);
            DL_pedido.DataBind();
            //us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            //GV_aliadoaprobar.DataBind();

        }
    }

    protected void GV_pedidocarrito_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Pedido pedido = (Pedido)e.Row.DataItem;
        int rowcount = GV_pedidocarrito.Rows.Count;
        if (rowcount == 0)
        {
            LB_pedidoscarrito.Visible = true;
        }
        else
        {
            LB_pedidoscarrito.Visible = false;
        }
        if (e.Row.FindControl("GV_detallespedido") != null)
        {
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataBind();
        }
    }
    //////////////////////
    protected void mostrardatosentrega(){
        TBX_direccion.Text = ((Usuario)Session["user"]).Direccion;
        TBX_telefono.Text = ((Usuario)Session["user"]).Telefono;
    }

    ////////////////

    protected void GV_pedidocarrito_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        DAOPedido daopedido = new DAOPedido();
        Pedido pedido2 = new Pedido();
        pedido2.Id_pedido = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Cancelar")
        {
            daopedido.Cancelarpedido(pedido2);
            GV_pedidocarrito.DataBind();

        }
    }
    protected void mostrarpreciototal(){
        DAOPedido dpedido = new DAOPedido();
        List<Pedido> pedido3 = new List<Pedido>();
        List<Detalle_pedido> detallepedido3 = new List<Detalle_pedido>();
        int idusuario = ((Usuario)Session["user"]).Id;
       pedido3 = dpedido.preciototal(idusuario);
    
        double total = 0;
        int idpedido8=0;
        foreach (var item in pedido3)
        {
            idpedido8=item.Id_pedido;
            detallepedido3 = dpedido.precioTotal2(idpedido8);
            foreach (var item2 in detallepedido3)
            {
                total += item2.V_total;
            }
        }
        TBX_subtotal1.Text = total.ToString();
    }

    protected void mostrarpreciodomicilio()
    {
        DAOPedido dpedido = new DAOPedido();
        List<Pedido> pedido3 = new List<Pedido>();
        Usuario usuario3 = new Usuario();
        int idusuario = ((Usuario)Session["user"]).Id;
        pedido3 = dpedido.PedidosTotal(idusuario);
        int total = 0;
        foreach (var item in pedido3)
        {
            total++;
        }
        TBX_cantidaddomicilios.Text = total.ToString();
        TBX_valordomicilio.Text = "3000";
        int cantidad=int.Parse(TBX_cantidaddomicilios.Text);
        double valordomicilio, resultado,total2,subtotal1;
        valordomicilio = int.Parse(TBX_valordomicilio.Text);
        resultado = cantidad * valordomicilio;
        TBX_totalpreciodomi.Text = resultado.ToString();
        subtotal1 = int.Parse(TBX_subtotal1.Text);
        total2 = resultado + subtotal1;
        TBX_total.Text = total2.ToString();
    }
    protected void BTN_comprar_Click(object sender, EventArgs e){
        
        DAOPedido dpedido = new DAOPedido();
        List<Pedido> pedido3 = new List<Pedido>();
       Detalle_pedido detapedido4 = new Detalle_pedido();
        Usuario usuario3 = new Usuario();
        int idusuario = ((Usuario)Session["user"]).Id;
        pedido3 = dpedido.pedidoscomprar(idusuario);
       
        detapedido4.Telefono_cliente = TBX_telefono1.Text;
        detapedido4.Direccion_cliente = TBX_direccion1.Text;
        //  int total = 0;68/64
        foreach (var item in pedido3)
        {
            dpedido.actualizarcomprar(item.Id_pedido);
            dpedido.actualizardatosentrega(item.Id_pedido, detapedido4);
        }
        Response.Redirect("Carrito.aspx");

    }

    protected void IB_validar_Click(object sender, ImageClickEventArgs e)
    {
        TBX_direccion1.Text = TBX_direccion.Text;
        TBX_telefono1.Text = TBX_telefono.Text;
        TBX_telefono1.Visible = true;
        TBX_direccion1.Visible = true;
    }

  
}