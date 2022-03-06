import { Box, Typography } from "@mui/material";
import React, { useEffect, useState } from "react";
import SearchBar from "../../ui-component/SearchBar";
import RecipeList from "./RecipeList";
import ButtonReusable from "../../ui-component/ButtonReusable";
import { listRecipesForCategory } from "../../../ApiService/RecipesApi";
import { useParams } from "react-router-dom";
const RecipesBody = () => {
  const { categorieName } = useParams();
  const [loadMore, setLoadMore] = useState(true);
  const [recipes, setRecipes] = useState([]);
  const [totalAvailableRecipes,setTotalAvailableRecipes] = useState(0)

  const addingNewRecipes = (response) => {
    if (!response.loadMore) {
      setLoadMore(false);
    }
    setTotalAvailableRecipes(response.totalDataNumber)
    setRecipes((prevState) => [...prevState, ...response.data]);
  };
   

  const onClickMoreHandler = () => {
    listRecipesForCategory(categorieName, recipes.length, 1)
      .then((res) => addingNewRecipes(res))
      .catch((err) => console.log(err));
  };

  useEffect(() => {
    listRecipesForCategory(categorieName, 0, 1)
      .then((res) => addingNewRecipes(res))
      .catch((err) => console.log(err));
  }, [categorieName]);

  return (
    <React.Fragment>
      <Box display="flex" justifyContent="space-between" sx={{  width: "100%"}} mt={2}>
        <Typography variant="h5">Total recipes: {totalAvailableRecipes}</Typography>
        <SearchBar />
      </Box>
      <RecipeList recipes={recipes} />
      {loadMore && <Box my={2} display="flex" justifyContent="center">
        <ButtonReusable variant="outlined" onClick={onClickMoreHandler}>
          Load more
        </ButtonReusable>
      </Box>}
    </React.Fragment>
  );
};

export default RecipesBody;
