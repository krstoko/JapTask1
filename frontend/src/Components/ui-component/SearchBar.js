import { InputBase } from "@mui/material";
import { styled } from "@mui/material/styles";
import SearchIcon from "@mui/icons-material/Search";
import React from "react";

const SearchIconWrapper = styled("div")(() => ({
  padding: "0 10px",
  height: "100%",
  position: "absolute",
  display: "flex",
  alignItems: "center",
  justifyContent: "center",
}));

const StyledInputBase = styled(InputBase)(() => ({
  paddingLeft: `40px`,
  height: "30px",
}));

const SearchBar = (props) => {
  const style = {
    paddingLeft: `40px`,
    height: "30px",
  };
  return (
    <div className="searchWrapper">
      <div className="searchIconWrapper">
        <SearchIcon />
      </div>
      <InputBase
        placeholder="Search…"
        inputProps={{ "aria-label": "search" }}
        sx={style}
      />
    </div>
  );
};

export default SearchBar;
