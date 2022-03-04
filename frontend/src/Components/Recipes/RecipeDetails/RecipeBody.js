import React from "react";
import Image from "../../ui-component/Image";
import RecipeInformations from "./RecipeInformations";

const RecipeBody = () => {
  return (
    <React.Fragment>
      <Image
        src="https://images.unsplash.com/photo-1512917774080-9991f1c4c750?auto=format&w=350&dpr=2"
        alt="Image"
      />
      <RecipeInformations />
    </React.Fragment>
  );
};

export default RecipeBody;
