<?php
require "config.php";

$name = $_POST['name'];
$description = $_POST['description'];


$image = null;
if(is_uploaded_file($_FILES["image"]['tmp_name'])){
    $image = $_FILES['image']['name'];
    move_uploaded_file($_FILES['image']['tmp_name'],"files/".$image);
}

$sql = "INSERT INTO products (title,description,image) VALUES(?,?,?)";
$statement = $pdo->prepare($sql);
$statement->bindValue(1,$name);
$statement->bindValue(2,$description);
$statement->bindValue(3,$image);
$statement->execute();

header("location:index.php");

?>