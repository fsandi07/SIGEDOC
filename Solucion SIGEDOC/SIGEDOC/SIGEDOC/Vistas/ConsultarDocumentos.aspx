<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarDocumentos.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarDocumentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <script type="text/javascript">

        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Acceso Denegado!, no cuenta con los permisos para Aceder a este Modulo, contacte al Administrador',

                timer: 4000,
                allowOutsideClick: false,
                onBeforeOpen: () => {

                    Swal.showLoading()

                    timerInterval = setInterval(() => {
                        Swal.getContent().querySelector('strong')
                            .textContent = (Swal.getTimerLeft() / 1000)
                                .toFixed(0)
                    }, 100)
                },
                onClose: () => {
                    clearInterval(timerInterval)
                }

            })


            window.setTimeout('location.href="Menu.aspx"', 4000)
        }

        // mensaje de error
        function mensajeError() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Lo sentimos a ocurrido un Error, por favor intentelo de nuevo," +
                    "Si el problema persiste contacte al Administrador " + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 4000,

            })
        }

        //mensaje de conrfimacion
        function mensajeDeconfirmacion() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "Los Datos se Guardaron Con Exito" + "!",
                type: 'success',
                allowOutsideClick: false,
            })
            window.setTimeout('location.href="consultarDocumentos.aspx"', 3000)
        }

        // mensaje error Docmuento

        function mensajeErrorDocumento() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Debe cargar un Documento" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 4000,

            })
        }

    </script>
    <div class="card shadow mb-4">
        <div class="card-body">
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                <asp:Label ID="Lblhead" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Consultar Documentos Creados</asp:Label>
            </a>
            <div class="collapse show" id="collapseCardExample">

                <asp:GridView ID="GridDocumento" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDatadocreados" OnRowDataBound="GridDocumento_RowDataBound" OnSelectedIndexChanged="GridDocumento_SelectedIndexChanged" Width="1026px" HorizontalAlign="Center" DataKeyNames="numtotaldocu" OnRowCommand="GridDocumento_RowCommand" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                    <Columns>

                        <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />

                        <asp:BoundField DataField="numtotaldocu" HeaderText="Id Doc" SortExpression="numtotaldocu" InsertVisible="False" ReadOnly="True" Visible="True" />
                        <asp:BoundField DataField="nombredcreado" HeaderText="Nombre" SortExpression="nombredcreado" />
                        <asp:BoundField DataField="asuntodcreado" HeaderText="Asunto" SortExpression="asuntodcreado" />
                        <asp:BoundField DataField="detalledCreadol" HeaderText="Detalle" SortExpression="detalledCreadol" />


                        <asp:ButtonField Text="<i class='far fa-file-pdf'></i>" CommandName="Editar" HeaderText="PDF" />

                        <asp:ButtonField Text="<i class='far fa-file-word'></i>" CommandName="Editar1" HeaderText="WORD" />

                        <asp:BoundField DataField="estatus" HeaderText="Estatus" SortExpression="estatus" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                        <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" Visible="False" />
                        <asp:BoundField DataField="nombrecliente" HeaderText="Nombre" SortExpression="nombrecliente" />
                        <asp:BoundField DataField="idProyecto" HeaderText="C.Costos" SortExpression="idProyecto" />
                        <asp:BoundField DataField="nombreusu" HeaderText="Usuario" SortExpression="nombreusu" />
                        <asp:BoundField DataField="numReferencia" HeaderText="Referencia" SortExpression="numReferencia" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDatadocreados" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="select a.numtotaldocu,a.nombredcreado,a.asuntodcreado,a.detalledCreadol,a.documentoPDF,a.documentoWord,a.estatus,a.fecha,a.idCliente,c.nombrecliente,a.idProyecto,b.nombreusu,a.numReferencia

from TbDocCreado a, TbUsuario b,TbCliente c where a.Usuario = b.cedulaUsu and a.idCliente=c.idCliente"></asp:SqlDataSource>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataDocCreado" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="select a.numtotaldocu,a.nombredcreado,a.asuntodcreado,a.detalledCreadol,a.documentoPDF,a.documentoWord,a.estatus,a.fecha,a.idCliente,c.nombrecliente,a.idProyecto,b.nombreusu,a.numReferencia

from TbDocCreado a, TbUsuario b,TbCliente c where a.Usuario = b.cedulaUsu and a.idCliente=c.idCliente"></asp:SqlDataSource>
    <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
    <div class="card shadow mb-4">
        <div class="card-body">
            <!-- Card Header - Accordion -->

            <a href="#collapseCardExample2" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Consultar Documentos Subidos</asp:Label>
            </a>
            <!-- Card Content - Collapse -->

            <div class="collapse show" id="collapseCardExample2">


                <asp:GridView ID="GridDocSubido" runat="server" Width="1026px" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="numTotalSub" DataSourceID="SqlDataDocSubido" OnSelectedIndexChanged="GridDocSubido_SelectedIndexChanged" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center" RowStyle-HorizontalAlign="Center" RowStyle-VerticalAlign="Middle" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Middle" EmptyDataRowStyle-HorizontalAlign="Center" EmptyDataRowStyle-VerticalAlign="Middle" CellSpacing="2" OnRowCommand="GridDocSubido_RowCommand">
                    <Columns>
                        <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
                        <asp:BoundField DataField="numTotalSub" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="numTotalSub" />
                        <asp:BoundField DataField="nombredSub" HeaderText="Nombre " SortExpression="nombredSub" />
                        <asp:BoundField DataField="detalledSub" HeaderText="Detalle" SortExpression="detalledSub" />

                        <asp:ButtonField Text="<i class='far fa-file-pdf'></i>" CommandName="PDF1" HeaderText="PDF" />

                        <asp:ButtonField Text="<i class='far fa-file-word'></i>" CommandName="WORD1" HeaderText="WORD" />

                        <asp:BoundField DataField="fechaSub" HeaderText="Fecha" SortExpression="fechaSub" />
                        <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" Visible="False" />
                        <asp:BoundField DataField="nombrecliente" HeaderText="Nombre" SortExpression="nombrecliente" />
                        <asp:BoundField DataField="idProyecto" HeaderText="idProyecto" SortExpression="idProyecto" />
                        <asp:BoundField DataField="nombreusu" HeaderText="Usuario" SortExpression="nombreusu" />
                        <asp:BoundField DataField="referenciaSub" HeaderText="Referencia" SortExpression="referenciaSub" />
                        <asp:BoundField DataField="Modificado Por" HeaderText="Modificado Por" SortExpression="Modificado Por" />
                    </Columns>

                    <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>

                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle"></EmptyDataRowStyle>

                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" BorderStyle="Inset" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataDocSubido" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="
select a.numTotalSub,a.nombredSub,a.detalledSub,a.documentoPdfSub,a.documentoWordSub,a.fechaSub,a.idCliente,c.nombrecliente,a.idProyecto,b.nombreusu,a.referenciaSub,a.ModificadoPor as[Modificado Por]

from tbdocsubido a, TbUsuario b,TbCliente c where  a.idCliente=c.idCliente and a.idUsuario = b.cedulaUsu"></asp:SqlDataSource>

            </div>
        </div>
    </div>

    <%--data-dismiss="modal"--%>
     <div class="card shadow mb-4">
        <div class="card-body">
            <a href="#collapseCardExample4" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                <asp:Label ID="lbbuscardocu" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Buscar Documento</asp:Label>
            </a>
            <div class="collapse show" id="collapseCardExample4">
                <asp:Label ID="lblBuscarDocs" runat="server" Text="Buscar Por Numero de Referencia"></asp:Label>
                <asp:DropDownList ID="DptbusacrReferencia" runat="server" AutoPostBack="True" DataSourceID="SqlDatabuscarfecha" DataTextField="numReferencia" DataValueField="numReferencia" OnSelectedIndexChanged="Dptbsucarfecha_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDatabuscarfecha" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [numReferencia] FROM [TbDocCreado]"></asp:SqlDataSource>
                <asp:Label ID="lbbsucarporcentroC" runat="server" Text="Buscar Por Nombre de documento"></asp:Label>
                <asp:DropDownList ID="dptbuscarnombreproyecto" runat="server" AutoPostBack="True" DataSourceID="SqlDatacencostos" DataTextField="nombredCreado" DataValueField="nombredCreado" OnSelectedIndexChanged="dptbuscarcencosto_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDatacencostos" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [nombredCreado] FROM [TbDocCreado]"></asp:SqlDataSource>
                <asp:GridView ID="GridBuscarDoc" runat="server"></asp:GridView>


        </div>
        </div>
    </div>

    <%-- finla de la modal  --%>    <%-- fin de la modal  --%>
    <div class="modal fade" id="ModalDocumentos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Actualizar este Documento?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Nombre del Documento<asp:TextBox class="req" ID="txtnombre" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Asunto<asp:TextBox ID="txtasunto" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Detalle<asp:TextBox ID="txtdetalle" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Usuario<asp:TextBox ID="txtusuario" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    centro de Costos:<asp:TextBox ID="txtcentrocostos" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Estado
                        <asp:DropDownList ID="dptestado" runat="server" CssClass="alert-dark">
                            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
                            <asp:ListItem Value="Terminado">Terminado</asp:ListItem>
                        </asp:DropDownList>
                    <br>
                    <asp:DropDownList ID="dptPeriodo" runat="server"></asp:DropDownList>Referencia:<asp:TextBox ID="txtreferencia" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Fecha De Creacion del Documento:<asp:TextBox ID="txtfecha" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Cargar documento 
                    <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="FileSubirWord" runat="server" />
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator1" runat="server"
                        ValidationExpression=".*(\.doc|\.DOCX|\.docx)$"
                        ControlToValidate="FileSubirWord">El formato del Archivo no es Word</asp:RegularExpressionValidator>
                    <br>
                    Subir Archivo PDF:
                      <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="FileSubirPdf" runat="server"
                          BackColor="Red" BorderColor="Red" />
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator2" runat="server"
                        ValidationExpression=".*(\.pdf|\.PDF)$"
                        ControlToValidate="FileSubirPdf">El formato del Archivo no es PDF</asp:RegularExpressionValidator>
                    <br>
                    <div class="modal-footer">
                        <asp:Button ID="btnActualizar" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btnActualizar_Click" />
                        <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
                        <%--data-dismiss="modal"--%>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%-- finla de la modal  --%>


    <%--Modal para cargar los datos --%>
    <div class="modal fade" id="ModalDocumentosSubidos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">¿Desea Actualizar este Documento?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Nombre del Documento<asp:TextBox class="req" ID="txtnombresubido" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Detalle<asp:TextBox ID="txtdetallesubido" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Usuario que creo el Docuemento<asp:TextBox ID="txtusuario_subido" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    centro de Costos:<asp:TextBox ID="txtcentro_costos" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    Nombre Cliente:<asp:TextBox ID="txtnombre_cliente" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    <asp:DropDownList ID="dptPeriodo1" runat="server"></asp:DropDownList>Referencia:<asp:TextBox ID="txtreferencia_Subido" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Fecha De Creacion del Documento:<asp:TextBox ID="txtcreacion" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Cargar documento 
                    <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="Filedocsubido_word" runat="server" />
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator3" runat="server"
                        ValidationExpression=".*(\.doc|\.DOCX|\.docx|\.DOC)$"
                        ControlToValidate="Filedocsubido_word">El formato del Archivo no es Word</asp:RegularExpressionValidator>
                    <br>
                    Subir Archivo PDF:
                      <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="Filedocsubiodo_pdf" runat="server"
                          BackColor="Red" BorderColor="Red" />
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator4" runat="server"
                        ValidationExpression=".*(\.pdf|\.PDF)$"
                        ControlToValidate="Filedocsubiodo_pdf">El formato del Archivo no es PDF</asp:RegularExpressionValidator>
                    <br>
                    <div class="modal-footer">
                        <asp:Button ID="btnactualizar_docSubido" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btnactualizar_docSubido_Click" />

                        <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
                        <%--data-dismiss="modal"--%>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%-- finla de la modal  --%>


    <%-- fin de la modal  --%>
</asp:Content>
