import React from "react";
import { Button } from "@mui/material";

const ButtonReusable = (props) => {
  return <Button {...props}>{props.children}</Button>;
};

export default ButtonReusable;
