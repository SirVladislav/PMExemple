<?php

require ('config.php');

$products = $pdo->query('SELECT * FROM products')->fetchAll(PDO::FETCH_ASSOC);

?>

<!DOCTYPE html>
<html>
<head>
	<title>My Test Site</title>
	<link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
</head>
<body>
	
<div class="container">
	<div class="row">
		<div class="col-md-10">
            <h1>My Site Functionality</h1>
            <a href="create.php" class="btn btn-success">Add to ...</a>
            <hr>
			<table class="table">
				<thead>
					<tr>
						<th>id</th>
						<th>Name</th>
						<th>Description</th>
						<th>Picture</th>
						<th>Do</th>
					</tr>
				</thead>
				<tbody>
                    <?php foreach ($products as $product):?>
                        <tr>
						    <td> <?php echo $product['id']; ?> </td>
						    <td><a href="show.php?title=<?php echo $product['title'];?>" > <?php echo $product["title"];?> </a></td>
						    <td><?php echo $product["description"]; ?></td>
                            <td><img width="150" height="150"  src="files/<?php echo $product["image"]; ?>"></td>
                            <td><a class="btn btn-warning" href="edit.php?title=<?php echo $product['title']; ?>">Edit</a>
                                <a class="btn btn-danger" href="databaseDelete.php?id=<?php echo $product['id']; ?>" onclick="return confirm('ok?')" >Delete</a></td>
					    </tr>
                    <?php endforeach;?>
				</tbody>

			</table>
		</div>
	</div>
</div>
</body>
</html>