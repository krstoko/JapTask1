import React from "react"
const RecipeContext = React.createContext({
    recipeName: "",
    description: "",
    category: {
        categoryName: ""
    }
})

export default RecipeContext;