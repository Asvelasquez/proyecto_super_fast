using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Utilitarios;
namespace Logica
{
    class LInicio
    {
        protected void DL_Productos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            ClientScriptManager cm = this.ClientScript;
            if (Session["user"] == null)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe iniciar session, para poder comprar');</script>");

            }
            else if (((UUsuario)(Session["user"])).Id_rol == 1)
            {
                DL_Productos.SelectedIndex = e.Item.ItemIndex;
                if (String.IsNullOrEmpty(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text) || String.IsNullOrEmpty(((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text))
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe Diligenciar todos los campos, para poder comprar');</script>");
                }
                else
                {

                    DAOPedido daoped = new DAOPedido();
                    List<UPedido> ped20 = new List<UPedido>();
                    UPedido pedido3 = new UPedido();
                    UDetalle_pedido det_pedido = new UDetalle_pedido();
                    DAOPedido dao = new DAOPedido();
                    ped20 = daoped.consultarpedido(((UUsuario)Session["user"]).Id);
                    int contador = 0;
                    foreach (var item in ped20)
                    {
                        if (item.Aliado_id == int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_IDaliado")).Text))
                        {
                            try
                            {
                                det_pedido.Pedido_id = item.Id_pedido;
                                det_pedido.Descripcion = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
                                det_pedido.V_unitario = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
                                det_pedido.Cantidad = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
                                det_pedido.Producto_id = int.Parse(e.CommandArgument.ToString());
                                det_pedido.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
                                det_pedido.Telefono_cliente = ((Usuario)Session["user"]).Telefono;
                                double valorunitario, resultado;
                                int cantidad5;
                                valorunitario = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
                                cantidad5 = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
                                resultado = valorunitario * cantidad5;
                                det_pedido.V_total = resultado;
                                new DAODetalle_Pedido().insertdetallePedido(det_pedido);
                                contador++;
                            }
                            catch (Exception) { throw; }

                        }

                    }
                    if (contador == 0)
                    {
                        try
                        {
                            pedido3.Cliente_id = ((Usuario)Session["user"]).Id;
                            pedido3.Fecha = DateTime.Now;
                            pedido3.Estado_id = 1;//1) posible compra 2)comprado 3)cancelado
                            pedido3.Aliado_id = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_IDaliado")).Text);
                            pedido3.Domiciliario_id = 1;
                            pedido3.Estado_pedido = 0;// 0) posible compra 1)comprado 2)cancelado
                            pedido3.Estado_domicilio_id = 1;
                            dao.insertPedido(pedido3);

                            det_pedido.Pedido_id = pedido3.Id_pedido;
                            det_pedido.Descripcion = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
                            det_pedido.V_unitario = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
                            det_pedido.Cantidad = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
                            det_pedido.Producto_id = int.Parse(e.CommandArgument.ToString());
                            det_pedido.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
                            det_pedido.Telefono_cliente = ((Usuario)Session["user"]).Telefono;
                            double valorunitario, resultado;
                            int cantidad5;
                            valorunitario = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
                            cantidad5 = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
                            resultado = valorunitario * cantidad5;
                            det_pedido.V_total = resultado;
                            new DAODetalle_Pedido().insertdetallePedido(det_pedido);
                        }
                        catch (Exception ex)
                        { return; }//
                    }
                }//else
            }//ELSE
        }
    }
}
