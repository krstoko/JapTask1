import { Box, Typography } from "@mui/material";
import React, { useCallback, useEffect, useState } from "react";
import SearchBar from "../../ui-component/SearchBar";
import RecipeList from "./RecipeList";
import ButtonReusable from "../../ui-component/ButtonReusable";
import {
  listRecipesForCategory,
  searchRecipes,
} from "../../../ApiService/RecipesApi";
import { useParams } from "react-router-dom";
import { recipesBodyStyle } from "../../Style/RecipesBodyStyle";
const RecipesBody = () => {
  const { categorieName } = useParams();
  const [loadMore, setLoadMore] = useState(true);
  const [recipes, setRecipes] = useState([]);
  const [totalAvailableRecipes, setTotalAvailableRecipes] = useState(0);
  const [searchValue, setSearchValue] = useState("");

  const onChangeHandler = (e) => {
    setSearchValue(e.target.value);
    if (e.target.value.length < 3) {
      getInitialRecipes("search");
    } else {
      searchRecipes(categorieName, e.target.value, 0, 9)
        .then((res) => {
          addingNewRecipes(res, "search");
        })
        .catch((err) => console.log(err));
    }
  };

  const getInitialRecipes = useCallback(
    (type) => {
      listRecipesForCategory(categorieName, 0, 9)
        .then((res) => addingNewRecipes(res, type))
        .catch((err) => console.log(err));
    },
    [categorieName]
  );

  const addingNewRecipes = (response, type) => {
    if (type === "search") {
      setRecipes(response.data);
    } else {
      setRecipes((prevState) => [...prevState, ...response.data]);
    }
    setTotalAvailableRecipes(response.totalDataNumber);
    setLoadMore(response.loadMore);
  };

  const onClickMoreHandler = () => {
    if (searchValue.length > 2) {
      searchRecipes(categorieName, searchValue, recipes.length, 2)
        .then((res) => {
          addingNewRecipes(res);
        })
        .catch((err) => console.log(err));
    } else {
      listRecipesForCategory(categorieName, recipes.length, 2)
        .then((res) => addingNewRecipes(res))
        .catch((err) => console.log(err));
    }
  };

  useEffect(() => {
    getInitialRecipes();
  }, [getInitialRecipes]);

  return (
    <React.Fragment>
      <Box sx={recipesBodyStyle}>
        <Typography variant="h5">
          Total recipes: {totalAvailableRecipes}
        </Typography>
        <SearchBar onChangeHandler={onChangeHandler} />
      </Box>
      <RecipeList recipes={recipes} />
      {loadMore && (
        <Box my={2} display="flex" justifyContent="center">
          <ButtonReusable variant="outlined" onClick={onClickMoreHandler}>
            Load more
          </ButtonReusable>
        </Box>
      )}
    </React.Fragment>
  );
};

export default RecipesBody;
