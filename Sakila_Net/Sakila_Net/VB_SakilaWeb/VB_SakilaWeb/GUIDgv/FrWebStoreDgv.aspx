<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrWebStoreDgv.aspx.vb" Inherits="VB_SakilaWeb.FrWebStoreDgv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
	<div class="span10">
        <div class="container span10 col-sm-7" >
			<div class="tab-content span10">
			    <div class="tab-pane active" id="tab_Empe">
					<div class="LoginDiv">
					    <fieldset>
					        <legend>Registros de Store</legend>
					        <div style="text-align: left;">
    <asp:GridView ID="GdData" runat="server" AutoGenerateColumns="False">
        <Columns>
<asp:BoundField DataField="store_id" FooterText="StoreId" HeaderText="StoreId" />
<asp:BoundField DataField="manager_staff_id" FooterText="ManagerStaffId" HeaderText="ManagerStaffId" />
<asp:BoundField DataField="address_id" FooterText="AddressId" HeaderText="AddressId" />
<asp:BoundField DataField="last_update" FooterText="LastUpdate" HeaderText="LastUpdate" />
            <asp:ButtonField ButtonType="Button" FooterText="Eliminar" HeaderText="tit" Text="Eliminar" ControlStyle-CssClass="btn  btn-primary ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover"/>
            <asp:ButtonField ButtonType="Button" FooterText="Editar" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn  btn-success ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover"/>
        </Columns>
    </asp:GridView>					        
					         <div style="text-align: center">
					                <asp:Label ID="lblError" runat="server" Text="UserId or Password is incorrect!" ForeColor="Red" Visible="False"></asp:Label>
					         </div>
              <div class="form-actions" >
                <table width='100%' border='0'><tr><td width='100%' align='right'>
                    <asp:Button runat="server" ID="btLeer" Text="Leer" OnClick1="btLeer_Click" CssClass="btn  btn-primary ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button runat="server" ID="btActualizar" Text="Actualizar" OnClick1="btActualizar_Click" CssClass="btn  btn-success ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button runat="server" ID="btEliminar" Text="Eliminar" OnClick1="btEliminar_Click" CssClass="btn  btn-danger ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button runat="server" ID="btListar" Text="Listar" OnClick1="btListar_Click" CssClass="btn  btn-info ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button runat="server" ID="btCancelar" Text="Cancelar" OnClick1="btCancelar_Click" CssClass="btn  btn-default ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                </td></tr></table>
              </div>
					        </div>
					    </fieldset>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
</asp:Content>
