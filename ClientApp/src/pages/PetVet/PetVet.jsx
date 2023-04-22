<<<<<<< HEAD
import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import FirstBlock from '../PetVet/FirstBlock'
import SecondBlock from './SecondBlock'
import ThirdBlock from './ThirdBlock'

const PetVet = () => {
    return (
        <div className='container mx-auto'>
            <Navbar />
            <FirstBlock />
            <SecondBlock/>
            <ThirdBlock />
           
        </div>
    )
}

export default PetVet
=======
import React, { useEffect, useState } from "react";
import Navbar from "../../components/Layouts/Navbar";
import FirstBlock from "../PetVet/FirstBlock";
import SecondBlock from "./SecondBlock";
import ThirdBlock from "./ThirdBlock";
import { useParams } from "react-router-dom";
import { getPropMasc } from "../../services/getPropMasc";

const PetVet = () => {
  const [Data, setData] = useState(null);
  const [Mascotas, setMascotas] = useState(null);
  const { id } = useParams();
  const getApi = async () => {
    let response = await getPropMasc(id);
    setData(response.prop);
    setMascotas(response.mascota);
  };
  useEffect(() => {
    getApi();
  }, []);
  return (
    <>
      <Navbar />

      <div className="container mx-auto">
        <FirstBlock prop={Data} />
        <SecondBlock nombre={Data?.nombre} />
        <ThirdBlock mascotas={Mascotas} />
      </div>
    </>
  );
};

export default PetVet;
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
