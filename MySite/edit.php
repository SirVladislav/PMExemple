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
    <title>Document</title>
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
</head>
<body>
    <div class="container">
        <div class="col-md-6">
            <h1>Add to Menu</h1>
            <hr>
            <form action="update.php" method="post" enctype="multipart/form-data">
                <input name="id" type="hidden" value="<?php echo $product['id'];  ?>">
                <div class="form-group">
                <label for="">Name of Product</label>
                <input name="title" class="form-control" type="text" value="<?php echo $product["title"]?>">
                </div>

                <div class="form-group">
                    <label for="">Description</label>
                    <input name="description" class="form-control" value="<?php echo $product["description"]?>">
                </div>

                <div class="form-group">
                    <label for="">Picture</label>
                    <input type="file" name="image">
                    <img src="files/<?php echo $product["image"];?>" width="150">
                </div>

                <button class="btn btn-warning">Edit THIS</button>
            </form>
        </div>
    </div>
</body>
</html>