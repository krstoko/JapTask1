import { Box, Typography } from "@mui/material";
import React from "react";
import SearchBar from "../ui-component/SearchBar";

const RecipesBody = () => {
  const style = {
    width: "100%",
  };

  return (
    <React.Fragment>
      <Box display="flex" justifyContent="space-between" sx={style} mt={2} >
        <Typography variant="h5">Total recipes: 20</Typography>
        <SearchBar />
      </Box>
    </React.Fragment>
  );
};

export default RecipesBody;
