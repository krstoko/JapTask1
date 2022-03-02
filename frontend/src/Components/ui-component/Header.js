import { AppBar, Button, InputBase, Toolbar } from "@mui/material";
import React from "react";
import SearchBar from "../ui-component/SearchBar";

const Header = (props) => {
  const style = {
    appBar: {
      boxShadow: "rgba(0, 0, 0, 0.45) 0px 25px 20px -20px",
    },
  };
  return (
    <AppBar position="static" color="default" sx={style.appBar}>
      <Toolbar>
       {props.children}
      </Toolbar>
    </AppBar>
  );
};

export default Header;
