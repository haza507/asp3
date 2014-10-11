@code
Page.Title = "Sumar"
  dim totalMessage = ""
if(IsPost)
    
    dim num1 = Request("text1")
    dim num2 = Request("text2")
    dim total = num1.AsInt() + num2.AsInt()
    totalMessage = "Total = " & total
End If
End Code
<!DOCTYPE html>
<html>
    <head>
    <title>Suma de dos numeros</title>
    </head>
<body style="background-color: #e6e829; font-family: Verdana, Arial;">
<form action="" method="post">
    <center>
    <h2>Suma de Dos Números</h2>
<p><label for="text1">Primer Número:</label><br>
<input type="text" name="text1"></p>
<p><label for="text2">Segundo Número </label><br>
<input type="text" name="text2"></p>
<p><input type="submit" value=" Sumar "></p>
        
</form>
<h3>@totalMessage</h3>
    </center>
</body>
</html>
