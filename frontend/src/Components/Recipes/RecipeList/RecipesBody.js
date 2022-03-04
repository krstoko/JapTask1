import { Box, Typography } from "@mui/material";
import React, { useState } from "react";
import SearchBar from "../../ui-component/SearchBar";
import RecipeList from "./RecipeList";
import ButtonReusable from "../../ui-component/ButtonReusable";
const RecipesBody = () => {
  const style = {
    width: "100%",
  };
  const [recipes, setRecipes] = useState([
    { name: "Test1", price: 22 },
    { name: "Test2", price: 23 },
    { name: "Test3", price: 21 },
    { name: "Test4", price: 24 },
    { name: "Test5", price: 25 },
    { name: "Test6", price: 26 },
    { name: "Test7", price: 27 },
    { name: "Test8", price: 21 },
    { name: "Test9", price: 22 },
  ]);

  const onClickMoreHandler = () => {};

  return (
    <React.Fragment>
      <Box display="flex" justifyContent="space-between" sx={style} mt={2}>
        <Typography variant="h5">Total recipes: 20</Typography>
        <SearchBar />
      </Box>
      <RecipeList recipes={recipes} />
      <Box my={2} display="flex" justifyContent="center">
        <ButtonReusable variant="outlined" onClick={onClickMoreHandler}>
          Load more
        </ButtonReusable>
      </Box>
    </React.Fragment>
  );
};

export default RecipesBody;
