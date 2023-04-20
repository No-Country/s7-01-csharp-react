import React, { useEffect, useState } from "react";
import Navbar from "../../components/Layouts/Navbar";
import FirstBlock from "./FirstBlock";
import SecondBlock from "./SecondBlock";
import ThirdBlock from "./ThirdBlock";
import FourBlock from "./FourBlock";
import { veterinaryAproved } from "../../services/veterinaryAproved";

const HomeVet = () => {
  const [Mascotas, setMascotas] = useState();
  const getMascotas = async () => {
    let response = await veterinaryAproved(1);
    console.log(
      "🚀 ~ file: HomeVet.jsx:13 ~ getMascotas ~ response:",
      response
    );
    setMascotas(response);
  };

  useEffect(() => {
    getMascotas();
  }, []);
  return (
    <>
      <Navbar />

      <div className="container mx-auto w-full h-full">
        <FirstBlock />
        <SecondBlock mascotas={Mascotas} />
        <FourBlock />
      </div>
    </>
  );
};

export default HomeVet;
