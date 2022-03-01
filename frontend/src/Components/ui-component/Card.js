import { Paper } from "@mui/material";
import React from "react";

const Card = (props) => {
  return (
    <Paper
      variant="outlined"
      sx={{ my: { xs: 3, md: 6 }, p: { xs: 2, md: 3 } }}
    >
      {props.children}
    </Paper>
  );
};

export default Card;
