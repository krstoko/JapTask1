import React from "react";
import { Button } from "@mui/material";

const ButtonReusable = (props) => {
  return (
    <Button type={props.type} fullWidth variant={props.variant} sx={props.sx}>
      {props.children}
    </Button>
  );
};

export default ButtonReusable;
