<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrWebFilmText.aspx.vb" Inherits="VB_SakilaWeb.FrWebFilmText" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!-- agregar MASTER EN EL FORM ==> class="form-horizontal well" -->

<div class="row">
	<div class="span10">
        <div class="container span10 col-sm-7" >
			<div class="tab-content span10">
			    <div class="tab-pane active" id="tab_Empe">
					<div class="LoginDiv">
					    <fieldset>
					        <legend>Mantenedor FilmText</legend>
					        <div style="text-align: left;">
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbFilmId" runat="server" Text="FilmId"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:textbox  Enabled="True" ID="TxtFilmId" runat="server" AutoPostBack="False" CssClass="cssNum" MaxLength="6" Width="90px"></asp:textbox>
				                       </div>
					            </div>
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbTitle" runat="server" Text="Title"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:textbox  Enabled="False" ID="TxtTitle" runat="server" AutoPostBack="False" CssClass="cssTxt" MaxLength="255" Width="800px"></asp:textbox>
				                       </div>
					            </div>
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbDescription" runat="server" Text="Description"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:textbox  Enabled="False" ID="TxtDescription" runat="server" AutoPostBack="False" CssClass="cssTEXT" MaxLength="1000" Width="800px"></asp:textbox>
				                       </div>
					            </div>
					         <div style="text-align: center">
					                <asp:Label ID="lblError" runat="server" Text="UserId or Password is incorrect!" ForeColor="Red" Visible="False"></asp:Label>
					         </div>
              <div class="form-actions" >
                <table width='100%' border='0'><tr><td width='100%' align='right'>
                    <asp:Button runat="server" ID="btLeer" Text="Leer" OnClick1="btLeer_Click" CssClass="btn  btn-primary ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button Enabled="False" runat="server" ID="btActualizar" Text="Actualizar" OnClick1="btActualizar_Click" CssClass="btn  btn-success ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
                    <asp:Button Enabled="False" runat="server" ID="btEliminar" Text="Eliminar" OnClick1="btEliminar_Click" CssClass="btn  btn-danger ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" align="right" />
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
