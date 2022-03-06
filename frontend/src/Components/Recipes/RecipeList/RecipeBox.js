import { Card, CardActionArea, CardContent, CardMedia, Grid, Typography } from "@mui/material";
import React from "react";
import { useNavigate } from "react-router-dom";

const RecipeBox = ({recipe}) => {
    const navigate = useNavigate()
    const style = {
        display: "flex",
        justifyContent: "space-between"
    }
    const onRecipeClick = () =>{
        navigate(`/recipe/${recipe.name}`)
    }

  return (
    <Grid item xs={12} sm={6} md={4}>
      <Card>
      <CardActionArea onClick={onRecipeClick}>
        <CardMedia
          component="img"
          height="140"
          image={recipe.recipeImgUrl}
          alt="green iguana"
        />
        <CardContent sx={style}>
          <Typography gutterBottom variant="h5" component="div">
            {recipe.recipeName}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {recipe.price}$
          </Typography>
        </CardContent>
        </CardActionArea>
      </Card>
    </Grid>
  );
};

export default RecipeBox;
