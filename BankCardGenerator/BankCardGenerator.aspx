<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankCardGenerator.aspx.cs" Inherits="BankCardGenerator.BankCardGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="lblTitle" runat="server" Text="Bank Card Generator" Font-Size="45" />
        </div>


        <div>
            <table id="tblbcg" runat="server">
                <tr>
                    <td><asp:Label runat="server" ID="firstName" Text="First Name" Font-Size="15" /></td>
                      <td><asp:TextBox runat="server" ID="txtFirstName" Width="200" /></td>
                </tr>
                 <tr>
                    <td><asp:Label runat="server" ID="middleName" Text="Middle Name" Font-Size="15" /></td>
                      <td><asp:TextBox runat="server" ID="txtMiddleName" Width="15" /></td>
                </tr>
                 <tr>
                    <td><asp:Label runat="server" ID="lastName" Text="Last Name" Font-Size="15" /></td>
                      <td><asp:textbox runat="server" id="txtlastname" width="200"  /></td>
                </tr>
             
            </table>

            <br />


        </div>

        

        <br /><br /><br /><br />

        <div>
            <table id="visaCardTbl" runat="server">
                  <tr>
                    <td><asp:Label ID="lblnameOnCardVisa" Text="Name on Card:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblFullNameOnVisa" runat="server" /></td>
                </tr>

                <tr>
                    <td><asp:Label ID="lblvisaCard" Text="Visa Card: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblVisaCardNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblvisaCSV" Text="Visa CSV: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblvisaCSVNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblvisaExp" Text="Visa Expiration:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblvisaExpDate" runat="server" /></td>
                </tr>
              

            </table>

            <asp:Button ID="btngenerateVISA" runat="server" Text="Create VisaCard" OnClick="btngenerateVISA_Click" />

        </div>


        <br />   <br />  

        <div>
            <table id="masterCardTbl" runat="server">
               <tr>
                    <td><asp:Label ID="lblnameOnCardMaster" Text="Name on Card:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblFullNameOnMaster" runat="server" /></td>
                </tr>

                <tr>
                    <td><asp:Label ID="lblmasterCard" Text="MasterCard: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblmasterCardNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblmasterCSV" Text="MasterCard CSV: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblmasterCSVNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblmasterExp" Text="MasterCard Expiration:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblmasterExpDate" runat="server" /></td>
                </tr>

            </table>

            <asp:Button ID="btngenerateMASTER" runat="server" Text="Create MasterCard" OnClick="btngenerateMASTER_Click" />

        </div>


        <br /><br />  

        <div>
            <table id="AmExCardTbl" runat="server">
                <tr>
                    <td><asp:Label ID="lblnameOnCardAmEx" Text="Name on Card:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblFullNameOnAmEx" runat="server" /></td>
                </tr>

                <tr>
                    <td><asp:Label ID="lblAmExp" Text="American Express: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblAmExpNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAmExCSV" Text="Express Card CSV: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblAmExpCSVNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAmExExp" Text="Express Card Expiration:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblAmExpExpDate" runat="server" /></td>
                </tr>

            </table>

              <asp:Button ID="btngenerateAmericanExpress" runat="server" Text="Create American Express" OnClick="btngenerateAmericanExpress_Click" />

        </div>

          <br />   <br />  

        <div>
            <table id="discoverCardTbl" runat="server">
                <tr>
                    <td><asp:Label ID="lblnameOnDiscover" Text="Name on Card:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblFullNameOnDiscover" runat="server" /></td>
                </tr>

                <tr>
                    <td><asp:Label ID="lbldiscoverCard" Text="Discover Card: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lbldiscoverCardNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbldiscoverCardCSV" Text="Discover Card CSV: "  Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lbldiscoverCardCSVNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbldiscoverExp" Text="Discover Expiration:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lbldiscoverExpDate" runat="server" /></td>
                </tr>

            </table>

             <asp:Button ID="btngenerateDISCOVER" runat="server" Text="Create DiscoverCard" OnClick="btngenerateDISCOVER_Click" />

        </div>

         <br />   <br />  

        <div>
            <table id="bankAccountInfoTbl" runat="server">
                <tr>
                    <td><asp:Label ID="lblbankAccount" Text="Bank Account Number:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblbankAccountNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblbankRouting" Text="Bank Routing Number:" Font-Bold="true" runat="server" /></td>
                    <td><asp:Label ID="lblbankRoutingNumber" runat="server" /></td>
                </tr>
              
            </table>

            <asp:Button ID="btngenerateBankInformation" runat="server" Text="Create Bank Account" OnClick="btngenerateBankInformation_Click" />

        </div>


    </form>
</body>
</html>
