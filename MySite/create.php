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
            <form action="databaseAdd.php" method="post" enctype="multipart/form-data">
                <div class="form-group">
                <label for="">Name of Product</label>
                <input class="form-control" type="text" name="name">
                </div>

                <div class="form-group">
                    <label for="">Description</label>
                    <input class="form-control" name="description">
                </div>

                <div class="form-group">
                    <label for="">Picture</label>
                    <input type="file" name="image">
                </div>

                <button class="btn btn-success">Add to store</button>
            </form>
        </div>
    </div>
</body>
</html>