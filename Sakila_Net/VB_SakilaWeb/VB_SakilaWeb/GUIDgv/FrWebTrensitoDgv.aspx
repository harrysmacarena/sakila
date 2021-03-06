<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrWebTrensitoDgv.aspx.vb" Inherits="VB_SakilaWeb.FrWebTrensitoDgv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
	<div class="span10">
        <div class="container span10 col-sm-7" >
			<div class="tab-content span10">
			    <div class="tab-pane active" id="tab_Empe">
					<div class="LoginDiv">
					    <fieldset>
					        <legend>Registros de Trensito</legend>
					        <div style="text-align: left;">
    <asp:GridView ID="GdData" runat="server" AutoGenerateColumns="False">
        <Columns>
<asp:BoundField DataField="Id" FooterText="Id" HeaderText="Id" />
<asp:BoundField DataField="nombre" FooterText="Nombre" HeaderText="Nombre" />
<asp:BoundField DataField="largo" FooterText="Largo" HeaderText="Largo" />
<asp:BoundField DataField="idMarca" FooterText="IdMarca" HeaderText="IdMarca" />
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
