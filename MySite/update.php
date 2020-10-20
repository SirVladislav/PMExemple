<?php
require "config.php";

$name = $_POST['title'];
$description = $_POST["description"];
$image = $_FILES['image'];
$id = $_POST['id'];

$statement = $pdo->prepare('UPDATE products SET title=?, description=? WHERE id=?');
$statement->bindValue(1,$name);
$statement->bindValue(2,$description);
$statement->bindValue(3,$id);
$statement->execute();

if(is_uploaded_file($_FILES["image"]['tmp_name'])) {
    $image = $_FILES['image']['name'];
    move_uploaded_file($_FILES['image']['tmp_name'], "files/" . $image);

    $statement = $pdo->prepare('UPDATE products SET image=? WHERE id=?');
    $statement->bindValue(1, $image);
    $statement->bindValue(2, $id);
    $statement->execute();

}

header("location:index.php");

?>