<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Day_1.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="showMessage" runat="server" OnTextChanged="showMessage_TextChanged"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="margin-bottom: 3px" Text="Show" />
        <p>
            &nbsp;
        </p>
        <asp:Label runat="server" Text="Start Number"></asp:Label>
        <asp:TextBox ID="startNumberTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="End Number"></asp:Label>
            <asp:TextBox ID="endNumberTextBox" runat="server" OnTextChanged="endNumber_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="ShowRange" runat="server" OnClick="ShowRange_Click" Text="Get The Range" />
        <br />
        <br />
        <hr />
        <asp:Label ID="Label3" runat="server" Text="Type Your Name Here"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="saveBtn" runat="server" Height="34px" Text="Save" OnClick="saveBtn_Click" />
            <asp:Button ID="showBtn" runat="server" Text="Show" Height="34px" OnClick="showBtn_Click" />
        </p>
        <p>
            <asp:Label ID="result" runat="server"></asp:Label>
        </p>
        <hr />

        <br />
        <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="studentNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="successMsg" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <asp:Button ID="addStudentBtn" runat="server" OnClick="addStudentBtn_Click" Text="Add Student" />
        <br />
        <br />
        <asp:Button ID="showStudentsBtn" runat="server" OnClick="showStudentsBtn_Click" Text="Show Students Details" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Students Count = "></asp:Label>
        &nbsp;<asp:Label ID="studentsCount" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="studentsListBox" runat="server" Width="149px"></asp:ListBox>
        <hr />


        <br />
        <asp:Label ID="Label7" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="sNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="sAgeTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="sEmailTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveStudentBtn" runat="server" OnClick="saveStudentBtn_Click" Text="Save" />
        &nbsp;
        <asp:Button ID="showStudentBtn" runat="server" OnClick="showStudentBtn_Click" Text="Show" />
        <br />
        <br />
        <asp:Label ID="successMsg2" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Name:"></asp:Label>
        &nbsp;<asp:Label ID="sName" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Age:"></asp:Label>
        &nbsp;<asp:Label ID="sAge" runat="server"></asp:Label>
        <br />
        <asp:Label runat="server" Text="Email"></asp:Label>
        &nbsp;<asp:Label ID="sEmail" runat="server"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="studentsListBox1" runat="server" Width="293px"></asp:ListBox>
        <br />
        <hr />


        <br />
        <asp:Label runat="server" Text="Basic Amount"></asp:Label>
        <asp:TextBox ID="basicTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label14" runat="server" Text="Rent"></asp:Label>
        <asp:TextBox ID="rentTextBox" runat="server"></asp:TextBox>
        % of basic<br />
        <asp:Label ID="Label15" runat="server" Text="Medical"></asp:Label>
        <asp:TextBox ID="medTextBox" runat="server"></asp:TextBox>
        % of basic<br />
        <br />
        <asp:Button ID="saveSalaryBtn" runat="server" OnClick="saveSalaryBtn_Click" Text="Save" />
        &nbsp;
        <asp:Button ID="showSalaryBtn" runat="server" OnClick="showSalaryBtn_Click" Text="Show Total Salary" />
        <br />
        <br />
        <asp:Label ID="salary" runat="server"></asp:Label>

        <hr />


        <asp:Label runat="server" Text="Vechile Name"></asp:Label>
        <asp:TextBox ID="vNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label17" runat="server" Text="RegNo"></asp:Label>
        <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="createRegNo" runat="server" OnClick="createRegNo_Click" Text="Create" />
        <br />
        <asp:Label ID="Label18" runat="server" Text="Speed"></asp:Label>
        <asp:TextBox ID="speedTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="Label19" runat="server" Text="Km/Hr"></asp:Label>
        <asp:Button ID="enter" runat="server" OnClick="enter_Click" Text="Enter" />
        <br />
        Min Speed<asp:TextBox ID="minSpeedTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label21" runat="server" Text="Max Speed"></asp:Label>
        <asp:TextBox ID="maxSpeedTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="showV" runat="server" OnClick="showV_Click" Text="Show" />
        <br />
        <asp:Label ID="Label22" runat="server" Text="Avg Speed"></asp:Label>
        <asp:TextBox ID="AvgTextBox" runat="server"></asp:TextBox>
        <br />

        <hr />

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="saveToSession" runat="server" OnClick="saveToSession_Click" Text="Save" />
        <br />
        <br />
        <asp:Button ID="go" runat="server" OnClick="go_Click" Text="Go To Another Page" />
        <hr />


        <br />
        <asp:Label ID="Label23" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label5" runat="server" Text="Contact No."></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />

        <br />
        <asp:Button ID="saveUserBtn" runat="server" Text="Save" OnClick="saveUserBtn_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="go_Click" Text="Go To Another Page" />

    </form>
</body>
</html>
