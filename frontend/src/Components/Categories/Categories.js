import { Typography } from "@mui/material";
import { Box } from "@mui/system";
import React, { useState } from "react";
import ButtonReusable from "../ui-component/Button";
import CenteredComponent from "../ui-component/ContainerPaper";
import CategoryList from "./CategoryList";

const Categories = () => {
  const onClickHandler = () => {
    console.log("A");
  };
  const [categories, setCategories] = useState([
    "Beef",
    "Bread",
    "Breakfast",
    "Cake",
    "Candy",
    "Chicken",
    "Italian",
    "Salad",
    "Pie",
    "Turkey",
  ]);
  return (
    <CenteredComponent maxWidth="lg">
      <Typography component="h4" variant="h4" align="center" margin="normal">
        Choose you recipe category
      </Typography>
      <CategoryList categories={categories} />
      <Box my={2} display="flex" justifyContent="center">
        <ButtonReusable variant="outlined" onClick={onClickHandler}>
          Load more
        </ButtonReusable>
      </Box>
    </CenteredComponent>
  );
};

export default Categories;
