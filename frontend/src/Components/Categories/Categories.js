import { Typography } from "@mui/material";
import { Box } from "@mui/system";
import React, { useEffect, useState } from "react";
import { listCategories } from "../../ApiService/CategoriesApi";
import ButtonReusable from "../ui-component/ButtonReusable";
import ContainerPaper from "../ui-component/ContainerPaper";
import CategoryList from "./CategoryList";

const Categories = () => {
  const [loadMore, setLoadMore] = useState(true);
  const [categories, setCategories] = useState([]);

  const addingNewCategories = (response) => {
    if (response.message === "Cant load more") {
      setLoadMore(false);
    }
    setCategories((prevState) => [...prevState, ...response.data]);
  };

  const onClickHandler = () => {
    listCategories(categories.length, 9)
      .then((response) => addingNewCategories(response))
      .catch((err) => console.log(err));
  };

  useEffect(() => {
    listCategories(categories.length, 9)
      .then((response) => addingNewCategories(response))
      .catch((err) => console.log(err));
  }, []);

  return (
    <ContainerPaper maxWidth="lg">
      <Typography component="h4" variant="h4" align="center">
        Choose you recipe category
      </Typography>
      <CategoryList categories={categories} />
      {loadMore && (
        <Box my={2} display="flex" justifyContent="center">
          <ButtonReusable variant="outlined" onClick={onClickHandler}>
            Load more
          </ButtonReusable>
        </Box>
      )}
    </ContainerPaper>
  );
};

export default Categories;
