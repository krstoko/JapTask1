import { Grid } from "@mui/material";
import React from "react";
import RecipeBox from "./RecipeBox";

const RecipeList = (props) => {
  return (
    <Grid container spacing={4} mt={1}>
      {props.recipes.map((recipe, id) => (
        <RecipeBox recipe={recipe} key={id} />
      ))}
    </Grid>
  );
};

export default RecipeList;
