<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrWebCity.aspx.vb" Inherits="VB_SakilaWeb.FrWebCity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!-- agregar MASTER EN EL FORM ==> class="form-horizontal well" -->

<div class="row">
	<div class="span10">
        <div class="container span10 col-sm-7" >
			<div class="tab-content span10">
			    <div class="tab-pane active" id="tab_Empe">
					<div class="LoginDiv">
					    <fieldset>
					        <legend>Mantenedor City</legend>
					        <div style="text-align: left;">
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbCityId" runat="server" Text="CityId"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:textbox  Enabled="True" ID="TxtCityId" runat="server" AutoPostBack="False" CssClass="cssNum" MaxLength="5" Width="75px"></asp:textbox>
				                       </div>
					            </div>
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbCity" runat="server" Text="City"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:textbox  Enabled="False" ID="TxtCity" runat="server" AutoPostBack="False" CssClass="cssTxt" MaxLength="50" Width="750px"></asp:textbox>
				                       </div>
					            </div>
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbCountryId" runat="server" Text="CountryId"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:DropDownList  Enabled="False" ID="ddCountryId" runat="server" Height="26px" Width="504px"></asp:DropDownList>
				                       </div>
					            </div>
					            <div style="padding: 5px"  class="form-group">
					                <label class="col-sm-3 control-label" ><asp:Label ID="lbLastUpdate" runat="server" Text="LastUpdate"></asp:Label></label>
				                       <div class="col-sm-3">
				        <asp:TemplateField HeaderText="Birth Date"><ItemTemplate><asp:Textbox Enabled="False" ID="cldLbLastUpdateLabel" Runat="Server" Text='<%# Eval("DateLastUpdate", "{0:d}") %>' /></ItemTemplate><EditItemTemplate><asp:Calendar  Enabled="False" ID="cldLastUpdate" runat="server" AutoPostBack="False" CssClass="cssFYH" MaxLength="20" Width="300px" SelectionMode="Day" ShowGridLines="True" VisibleDate='<%# Eval("DateLastUpdate") %>'  SelectedDate='<%# Bind("DateLastUpdate") %>'></asp:Calendar></EditItemTemplate></asp:TemplateField> 
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
