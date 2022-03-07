import { Divider, Grid, Typography } from "@mui/material";
import { Box } from "@mui/system";
import React, { useContext } from "react";
import RecipeContext from "../../../store/recipetDetails-content";

const RecipeDetails = () => {
  const style = {
    higher: {
      borderLeft: "5px solid #316c6b",
      pl: 2,
    },
    paragraph: {
      wordWrap: "break-word",
    },
  };
  const recipeDetails = useContext(RecipeContext);
  console.log(recipeDetails)
  return (
    <Grid item xs={12} sm={12} md={6}>
      <Typography variant="h5" align="center">
        Recipe Details
      </Typography>
      <Divider />
      <Box component="div" pt={3}>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Name:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
          {recipeDetails.recipeName}
        </Typography>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Category:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
          {recipeDetails.category.categoryName}
        </Typography>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Description:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
         {recipeDetails.description}
        </Typography>
      </Box>
    </Grid>
  );
};

export default RecipeDetails;
