<?php
require "config.php";

$statement = $pdo->prepare("DELETE FROM products WHERE id=?");
$statement->bindValue(1,$_GET['id']);
$statement->execute();

header("location:index.php");
?>