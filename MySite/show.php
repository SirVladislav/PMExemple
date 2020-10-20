<?php

require ('config.php');

$statement = $pdo->prepare("SELECT * FROM products WHERE title=:title");
$statement->execute($_GET);
$product=$statement->fetch(PDO::FETCH_ASSOC);

?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <title>Show</title>
</head>

<body>
<div class="container">
    <div class="col-md-8">
        <div><h1>Просмотр товара </h1> <?php echo $product["title"]; ?> </div>
        <div><p><h3> Описание </h3> <?php echo $product['description']; ?></p></div>
        <div><p><h3>Picture</h3></p></div>
        <div><img src="files/<?php echo $product['image'];?>" width="200"></div>
    </div>
</div>

</body>

</html>
