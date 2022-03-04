import React from 'react';
import ContainerPaper from '../../ui-component/ContainerPaper';
import Header from '../../ui-component/Header';
import RecipeAddBody from './RecipeAddBody';

const RecipeAdd = () => {
    return (
        <ContainerPaper maxWidth="lg">
            <Header />
            <RecipeAddBody />
        </ContainerPaper>
    );
};

export default RecipeAdd;