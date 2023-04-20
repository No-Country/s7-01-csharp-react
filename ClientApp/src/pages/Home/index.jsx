import React, { useEffect, useState } from "react";

import Navbar from "../../components/Layouts/Navbar";
import RememberCards from "./RememberCards";
import ClinicCard from "./ClinicCard";
import ShowPets from "./ShowPets";

// services

// redux
// import { useSelector, useDispatch } from "react-redux";

const Home = () => {
  return (
    <>
      <Navbar />
      <ShowPets />      
      <ClinicCard />
    </>
  );
};

export default Home;
