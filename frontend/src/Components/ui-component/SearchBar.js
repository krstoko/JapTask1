import { InputBase } from "@mui/material";
import React from "react";

const SearchBar = (props) => {
    const style = {
        border: "1px solid black"
    }
  return <InputBase sx={style} {...props} />;
};

export default SearchBar;
