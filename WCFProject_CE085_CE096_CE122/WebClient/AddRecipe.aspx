﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRecipe.aspx.cs" Inherits="WebClient.AddRecipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Recipe</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <!-- For ICONS -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous"/>
</head>
<body>
    <header>
        <h2 class="bg-secondary p-2 text-light">
                <img id="sitelogo" style="height:40px;width:40px" src="/Images/sitelogo.jpg" alt="No image">
                Zaika
                <a href="" class="btn btn-light" runat="server" id="myhome"><i class="fas fa-home"></i> Home</a>
                <a href="" class="btn btn-light" runat="server" id="myrecipes"><i class="fas fa-box-open"></i> My Recipes</a>
                <a href="#" class="btn btn-light" runat="server" id="add"><i class="fas fa-pizza-slice"></i> Add Recipes</a>
                <a href="#" class="btn btn-light" runat="server"  id="profile"><i class="fas fa-user-alt"></i> Profile</a>
                <a href="Login.aspx" class="btn btn-light" runat="server" id="logout"><i class="fas fa-sign-out-alt"></i> Logout</a>
        </h2>
    </header>
    <form id="form1" runat="server">
        <div class="container w-75 mt-3">
            <h3 style="color:blue;">Add Recipe Details</h3>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <div class="form-group row">
                <label for="title" class="col-sm-2 col-form-label">Title:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" placeholder="Enter recipe name" id="title" runat="server" required="required"/>
                </div>
            </div>
            <div class="form-group row">
                <label for="ingredients" class="col-sm-2 col-form-label">Ingredients:</label>
                <div class="col-sm-10">
                    <textarea rows="3" cols="40" class="form-control" placeholder="Enter ingredients" id="ingredients" runat="server" required=""></textarea>
                </div>
            </div>
            <div class="form-group row">
                <label for="method" class="col-sm-2 col-form-label">Method:</label>
                <div class="col-sm-10">
                    <textarea rows="6" cols="40" class="form-control" placeholder="Enter recipe procedure" id="method" runat="server" required=""></textarea>
                </div>
            </div>
            <!--SouthIndian, Gujarati, Punjabi, Chinese, Diet, Snacks/Breakfast, Lunch, Sweet, Dessert, Other-->
            <div class="form-group row">
                <label for="category" class="col-sm-2 col-form-label">Category:</label>
                <div class="col-sm-10">
                    <asp:DropDownList ID="category" runat="server" class="custom-select">
                        <asp:ListItem Value="-1">Please Select</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group row">
                <label for="other" class="col-sm-2 col-form-label">Other Details:</label>
                <div class="col-sm-10">
                    <textarea rows="2" cols="40" class="form-control" id="other" placeholder="" runat="server"></textarea>
                </div>
            </div>
            <div class="form-group row">
                <label for="FileUpload1" class="col-sm-2 col-form-label">Photo:</label>
                <div class="col-sm-10">
                    <div class="custom-file">
                        <asp:FileUpload ID="FileUpload1" class="form-control custom-file-input" runat="server" />
                        <label class="custom-file-label">Choose Photo..</label>
                    </div>
                </div>
            </div>
            <br />
            <div class="form-group row">
                <div class="col-sm-10">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" text="ADD Recipe" ID="button" OnClick="button_Click"></asp:Button>
                </div>
            </div>
            
        </div>
        <!-- script to reflect filename in photo label-->
        <script>
            $(document).ready(function () {
                $('.custom-file-input').on('change', function () {
                    var filename = $(this).val().split("\\").pop();
                    $(this).next('.custom-file-label').html(filename);
                });
            });
            
        </script>
    </form>
</body>
</html>
