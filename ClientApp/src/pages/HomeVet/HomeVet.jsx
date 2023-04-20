import React from "react";
import Navbar from "../../components/Layouts/Navbar";
import FirstBlock from "./FirstBlock";
import SecondBlock from "./SecondBlock";
import ThirdBlock from "./ThirdBlock";
import FourBlock from "./FourBlock";

const HomeVet = () => {
  return (
    <div className="container mx-auto w-full h-full">
      <Navbar />
      <FirstBlock />
      <SecondBlock />    
      <FourBlock />
    </div>
  );
};

export default HomeVet;
