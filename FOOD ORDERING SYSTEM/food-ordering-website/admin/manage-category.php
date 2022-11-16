<?php include('partials/menu.php'); ?>

        <div class="main-content">
            <div class="wrapper">
                <h1>Manage Category</h1>

                <br>
                <br>

                <?php
                    if(isset($_SESSION['add']))
                    {
                        echo $_SESSION['add'];
                        unset($_SESSION['add']);
                    }

                    if (isset($_SESSION['delete']))
                    {
                        echo $_SESSION['delete'];
                        unset($_SESSION['delete']);
                    }

                    if (isset($_SESSION['remove']))
                    {
                        echo $_SESSION['remove'];
                        unset($_SESSION['remove']);
                    }

                    if (isset($_SESSION['no-category-found']))
                    {
                        echo $_SESSION['no-category-found'];
                        unset($_SESSION['no-category-found']);
                    }

                    if (isset($_SESSION['update']))
                    {
                        echo $_SESSION['update'];
                        unset($_SESSION['update']);
                    }

                    if (isset($_SESSION['upload']))
                    {
                        echo $_SESSION['upload'];
                        unset($_SESSION['upload']);
                    }

                    if (isset($_SESSION['remove-image']))
                    {
                        echo $_SESSION['remove-image'];
                        unset($_SESSION['remove-image']);
                    }
                ?>

                <br>
                <br>
                <br>

                <a href="<?php echo SITEURL; ?>admin/add-category.php" class="btn-primary">Add Category</a>
                <br>
                <br>
                <br>


                <table class="tbl-full">
                    <tr>
                        <th>SrNo.</th>
                        <th>Title</th>
                        <th>Image</th>
                        <th>Featured</th>
                        <th>Active</th>
                        <th>Actions</th>
                    </tr>

                    <?php
                        $sql = "SELECT * FROM tbl_category";
                        $res = mysqli_query($conn, $sql);

                        $count = mysqli_num_rows($res);

                        $sn = 1;

                        if($count>0)
                        {
                            while($rows = mysqli_fetch_assoc($res))
                            {
                                $id = $rows['id'];
                                $title = $rows['title'];
                                $image_name = $rows['image_name'];
                                $featured = $rows['featured'];
                                $active = $rows['active'];

                                ?>
                                    <tr>
                                        <td><?php echo $sn++; ?></td>
                                        <td><?php echo $title; ?></td>
                                        <td>
                                            <?php
                                                if($image_name!="")
                                                {
                                                    ?>
                                                        <img src="<?php echo SITEURL; ?>images/category/<?php echo $image_name; ?>" width="200px">
                                                    <?php
                                                }
                                                else
                                                {
                                                    echo "<div class='error'>No Image Found</div>";
                                                }
                                            ?>
                                        </td>
                                        <td><?php echo $featured; ?></td>
                                        <td><?php echo $active; ?></td>
                                        <td>
                                            <a href="<?php echo SITEURL; ?>admin/update-category.php?id=<?php echo $id; ?>" class="btn-secondary">Update Category</a>
                                            <a href="<?php echo SITEURL; ?>admin/delete-category.php?id=<?php echo $id; ?>&image_name=<?php echo $image_name; ?>" class="btn-danger">Delete Category</a>
                                        </td>
                                    </tr> 
                                <?php
                            }
                        }
                        else
                        {
                            ?>
                            <tr>
                                <td colspan="6"><div class='error'>No Category Added</div></td>
                            </tr>
                            <?php
                        }
                    ?>

                </table>
            </div>
        </div>

<?php include('partials/footer.php') ?>